using MilaShopParser;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace ParseMila
{
    public class ParseProduct
    {
        public static async Task<List<Product>> GetProducts(string url, int countProduct)
        {
            List<string> allLinks = await ParseTools.GetAllLinkProduct(url, countProduct);
            List<Product> products = new();
            List<Task<Product>> tasks = new();

            foreach (string link in allLinks)
            {
                tasks.Add(GetProductFromLink(link));

                if (tasks.Count == 10)
                {
                    products.AddRange(await ProcessTasks(tasks));
                }
            }

            if (tasks.Count > 0)
            {
                products.AddRange(await ProcessTasks(tasks));
            }

            return products;
        }

        private static async Task<Product> GetProductFromLink(string link)
        {
            var product = await ParsePage(link);
            await DelayRandomTime();
            return product;
        }

        private static async Task DelayRandomTime()
        {
            Random random = new();
            int time = random.Next(1000, 5000);
            await Task.Delay(time);
        }

        private static async Task<List<Product>> ProcessTasks(List<Task<Product>> tasks)
        {
            var completedTasks = await Task.WhenAll(tasks);
            tasks.Clear();
            return completedTasks.ToList();
        }

        private static async Task<Product> ParsePage(string url)
        {
            Product p = new();

            string htmlContent = await HttpClientHelper.LoadPageAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            p.Name = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='h1 mobile-element']").InnerText;
            var discountPriceNode = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='card-price']//div[@class='price']");
            string discountPrice = discountPriceNode.ChildNodes[0].InnerText + "." + discountPriceNode.SelectSingleNode("span").InnerText ?? " ";
            p.DiscountPrice = discountPrice;

            if (htmlDocument.DocumentNode.SelectSingleNode("//div[@class='card-price']//div[@class='price-old']") != null)
            {
                var priceNode = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='card-price']//div[@class='price-old']");
                string price = priceNode.ChildNodes[0].InnerText + "." + priceNode.SelectSingleNode("span").InnerText ?? " ";
                p.FullPrice = price;
            }

            var accordionBlockNode = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='accordion-block description-wrap open']//div[@class='left']//div[@class='info']");

            var brandNode = accordionBlockNode.SelectSingleNode(".//p[contains(., 'Бренд:')]");
            var brand = brandNode != null ? brandNode.InnerText.Split(':')[1].Trim() : string.Empty;
            p.Brand = brand;

            var providerNode = accordionBlockNode.SelectSingleNode(".//p[contains(., 'Поставщик:')]");
            var provider = providerNode != null ? providerNode.InnerText.Split(':')[1].Trim() : string.Empty;
            p.Provider = provider;

            var addressNode = accordionBlockNode.SelectSingleNode(".//p[contains(., 'Адрес поставщика:')]");
            var address = addressNode != null ? addressNode.InnerText.Split(':')[1].Trim() : string.Empty;
            p.AdressProvider = address;

            var countryNode = accordionBlockNode.SelectSingleNode(".//p[contains(., 'Страна происхождения:')]");
            var country = countryNode != null ? countryNode.InnerText.Split(':')[1].Trim() : string.Empty;
            p.CountryOfOrigin = country;

            return p;
        }
    }
}
