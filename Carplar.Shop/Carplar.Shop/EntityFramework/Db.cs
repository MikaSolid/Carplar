using Microsoft.EntityFrameworkCore;

namespace Carplar.Shop.EntityFramework
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options) {

        }
    }
}
