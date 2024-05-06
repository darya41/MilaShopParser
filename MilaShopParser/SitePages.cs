using HtmlAgilityPack;

namespace ParseMila
{
    internal class SitePages
    {
        public static async Task<List<string>> ParsePageAsync(string page)
        {
            List<string> allLinks = [];
            var tasks = new List<Task<List<string>>>();

            var web = new HtmlWeb();
            string url = "https://mila.by/" + page;
            var htmlDocument = await web.LoadFromWebAsync(url);

            var semaphore = new SemaphoreSlim(10);

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
                using var httpClient = new HttpClient();
                var web = new HtmlWeb();
                var htmlDocument = await web.LoadFromWebAsync(url);

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
