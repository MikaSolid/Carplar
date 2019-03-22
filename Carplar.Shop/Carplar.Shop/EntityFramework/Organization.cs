namespace Carplar.Shop.EntityFramework
{
    public class Organization : DbRecord
    {
        public virtual Party Party { get; set; }
    }
}