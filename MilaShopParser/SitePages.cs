using MilaShopParser;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace ParseMila
{
    internal class SitePages
    {
        public static async Task<List<string>> ParsePageAsync(string page)
        {
            List<string> allLinks = [];
            var tasks = new List<Task<List<string>>>();

            string url = "https://mila.by/" + page;
            var htmlContent = await HttpClientHelper.LoadPageAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            var semaphore = new SemaphoreSlim(15);

            if (htmlDocument.DocumentNode.SelectSingleNode("//a[@class='pagination']") == null)
            {
                tasks.Add(ParseOne(url, semaphore));
            }
            else
            {
                int p = int.Parse(htmlDocument.DocumentNode.SelectSingleNode("//a[@class='pagination']").InnerText) + 1;
                for (int k = 1; k < p; k++)
                {
                    string pageUrl = url + "?page=" + k;
                    tasks.Add(ParseOne(pageUrl, semaphore));
                }
            }

            var results = await Task.WhenAll(tasks);
            foreach (var result in results)
            {
                allLinks.AddRange(result);
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
