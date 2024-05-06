using Newtonsoft.Json;

namespace ParseMila
{
    internal class WriteToJson
    {
        public static void Wtite(List<Product> products, Link link)
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            File.WriteAllText(link.Url, json);
        }

    }
}
