namespace Carplar.Shop.EntityFramework
{
    public class PostalAddress
    {
        public int PostalAddressId { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string City { get; set; }

        public string IsoCountry { get; set; }
    }
}