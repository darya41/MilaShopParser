using HtmlAgilityPack;

namespace ParseMila
{
    public class ParseLinkSection
    {
        public static List<string> ParseLinkMila()
        {

            string url = "https://mila.by/";
            var web = new HtmlWeb();
            var htmlDocument = web.Load(url);

            var linkNodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='limited-container']//a[@class='link']");
            Console.WriteLine(htmlDocument);

            List<string> links = [];

            foreach (var linkNode in linkNodes)
            {
                links.Add(linkNode.GetAttributeValue("href", ""));
            }

            return links;
        }
    }
}
