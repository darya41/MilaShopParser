using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace ParseMila
{
    public class ParseLinkSection
    {
        public static async Task<List<string>> ParseLinkMilaAsync()
        {

            string url = "https://mila.by/";
            string htmlContent = await MilaShopParser.HttpClientHelper.LoadPageAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            var linkNodes = htmlDocument.DocumentNode.SelectNodes("//div[@class='limited-container']//a[@class='link']");

            List<string> links = [];

            foreach (var linkNode in linkNodes)
            {
                links.Add(linkNode.GetAttributeValue("href", ""));
            }

            return links;
        }
    }
}
