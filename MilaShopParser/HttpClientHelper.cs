namespace MilaShopParser
{
    public class HttpClientHelper
    { 
        private static readonly HttpClient httpClient = new();

        public static async Task<string> LoadPageAsync(string url)
        {
            return await httpClient.GetStringAsync(url);
        }
    }
}
