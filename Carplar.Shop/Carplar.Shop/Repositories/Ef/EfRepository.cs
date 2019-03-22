using Carplar.Shop.EntityFramework;
using System;

namespace Carplar.Shop.Repositories
{
    public class EfRepository : IRepository
    {
        public EfRepository(Db context) {
            Shop = new ShopRepository(context);
            Customer = new CustomerRepository();
        }

        public IShopRepository Shop { get; private set; }

        public ICustomerRepository Customer { get; private set; }
    }
}
