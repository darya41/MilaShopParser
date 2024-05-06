using  Newtonsoft.Json;

namespace ParseMila
{
    internal class ReadJson
    {

        public static List<Link> ReadJsonFile(string filePath)
        {
            using StreamReader r = new(filePath);
            string json = r.ReadToEnd();
            List<Link> links = JsonConvert.DeserializeObject<List<Link>>(json);
            return links;
        }

    }
}
