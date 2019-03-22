namespace Carplar.Shop.EntityFramework
{
    public class Organization : DbRecord
    {
        public int OrganizationId { get; set; }
        public int PartyId { get; set; }
        public virtual Party Party { get; set; }
    }
}