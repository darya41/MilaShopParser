
namespace MilaShopParser
{
    public class Section
    {
        private string? NameSection;
        private string? UrlSection;
        private int CountProduct;
        public Section(string nameSection, string urlSection, int countProduct)
        {
            NameSection = nameSection;
            UrlSection = urlSection;
            CountProduct = countProduct;
        }
        public Section()
        {

        }
        public string? GetUrlSection()
        {
            return UrlSection;
        }
        public string? GetNameSection()
        {
            return NameSection;
        }
        public int GetCountProduct()
        {
            return CountProduct;
        }
        public void SetUrlSection(string value)
        {
            UrlSection = value;
        }
        public void SetNameSection(string value)
        {
            NameSection = value;
        }
        public void SetCountProduct(int value) 
        { 
         CountProduct = value;
        }
    }
}
