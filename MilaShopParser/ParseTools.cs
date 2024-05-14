using HtmlAgilityPack;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace MilaShopParser
{
    public class ParseTools
    {
        public static async Task<List<Section>> GetLinkSection()
        {
            string url = "https://mila.by/";
            string htmlContent = await HttpClientHelper.LoadPageAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            var linkNodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='limited-container']//a[@class='link']");

            List<Task<Section>> sectionTasks = new List<Task<Section>>();

            foreach (var linkNode in linkNodes)
            {
                var section = await CreateSection(linkNode);
                if (section != null)
                {
                    sectionTasks.Add(Task.FromResult(section));
                }
            }

            var sections = await Task.WhenAll(sectionTasks);

            return sections.ToList();
        }

        private static async Task<Section> CreateSection(HtmlNode linkNode)
        {
            string nameSection = linkNode.InnerText.Trim().Replace("&nbsp;", " ");

            if (nameSection != "Электронные сертификаты" && nameSection != "Акции")
            {
                Section section = new();
                section.SetNameSection(nameSection);
                section.SetUrlSection(linkNode.GetAttributeValue("href", ""));
                section.SetCountProduct(await GetKolProduct(section.GetUrlSection()));
                return section;
            }

            return null;
        }

        public static async Task<int> GetKolProduct(string urlPage)
        {
            string htmlContent = await HttpClientHelper.LoadPageAsync("https://mila.by/" + urlPage);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            var node = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='count']");
            string countText = node.InnerText;

            return int.Parse(Regex.Match(countText, @"\d+").Value);

        }

        public static async Task<List<string>> GetAllLinkProduct(string page, int Count)
        {
            List<string> allLinks = new();

            string url = "https://mila.by/" + page;
            var htmlContent = await HttpClientHelper.LoadPageAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            var semaphore = new SemaphoreSlim(32);

            if (htmlDocument.DocumentNode.SelectSingleNode("//a[@class='pagination']") == null)
            {
                var result = await ParseOne(url, semaphore);
                if (allLinks.Count < Count)
                {
                    allLinks.AddRange(result);
                }
            }
            else
            {
                int p = int.Parse(htmlDocument.DocumentNode.SelectSingleNode("//a[@class='pagination']").InnerText) + 1;
                bool shouldBreak = false;
                for (int k = 1; k < p; k++)
                {
                    if (shouldBreak)
                    {
                        break;
                    }
                    string pageUrl = url + "?page=" + k;
                    var result = await ParseOne(pageUrl, semaphore);
                    foreach (var link in result)
                    {
                        if (allLinks.Count < Count)
                        {
                            allLinks.Add(link );
                        }
                        else
                        {
                            shouldBreak = true; 
                            break;
                        }
                    }                   
                }
            }

            return allLinks;
        }
        public static async Task<List<string>> ParseOne(string url, SemaphoreSlim semaphore)
        {
            await semaphore.WaitAsync();

            List<string> linksOnPage = [];
            List<string> links = [];
            try
            {
                Console.WriteLine("Паршу страницу  " + url + "\n");
                var htmlContent = await HttpClientHelper.LoadPageAsync(url);

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                if (htmlDocument != null)
                {
                    linksOnPage = htmlDocument.DocumentNode.Descendants("a")
                        .Where(node => node.GetAttributeValue("class", "").Equals("offer-link"))
                        .Select(node => node.GetAttributeValue("href", "")).Distinct()
                        .ToList();
                }
                foreach (var link in linksOnPage)
                {
                    links.Add("https://mila.by/" + link);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при парсинге страницы: {ex.Message}");
            }
            finally
            {
                semaphore.Release();
            }
            return links;
        }
    }
}


