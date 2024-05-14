namespace ParseMila
{
    public class Product
    {
        public string?Name { get; set; } 
        public string?DiscountPrice { get; set; } 
        public string?FullPrice { get; set; } 
        public string?Brand { get; set; } 
        public string?Provider { get; set; } 
        public string?AdressProvider { get; set; }
        public string?CountryOfOrigin { get; set; }
        public Product(string name, string discountPrice, string fullPrice, string brand, string provider,
        string adressProvider, string coiuntryOfOrigin)
        {
      Name = name;
            DiscountPrice = discountPrice;
                
            FullPrice = fullPrice;
            Brand = brand;
            Provider = provider;
            AdressProvider = adressProvider;
            CountryOfOrigin = coiuntryOfOrigin;

        }
        public Product()
        {

        }


    }
   
}