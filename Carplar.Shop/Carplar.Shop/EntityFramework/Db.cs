using Microsoft.EntityFrameworkCore;

namespace Carplar.Shop.EntityFramework
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options) {

        }

        public DbSet<Party> Parties { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleGroup> ArticleGroups { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<PurchaseItem> PurchaseItems { get; set; }

        public DbSet<PostalAddress> PostalAddresses { get; set; }

        public DbSet<ShopItem> ShopItems { get; set; }

        public DbSet<Shipment> Shipments { get; set; }
    }
}
