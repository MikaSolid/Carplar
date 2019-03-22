namespace Carplar.Shop.EntityFramework
{
    public class Party : DbRecord
    {
        public int PartyId { get; set; }

        public virtual PostalAddress PostalAddress { get; set; }
    }
}
