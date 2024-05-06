namespace ParseMila
{
    public class Product(string name, string discountPrice, string fullPrice, string brand, string provider,
        string adressProvider, string coiuntryOfOrigin)
    {
        public string Name { get; set; } = name;
        public string DiscountPrice { get; set; } = discountPrice;
        public string FullPrice { get; set; } = fullPrice;
        public string Brand { get; set; } = brand;
        public string Provider { get; set; } = provider;
        public string AdressProvider { get; set; } = adressProvider;
        public string CountryOfOrigin { get; set; } = coiuntryOfOrigin;
    }
}