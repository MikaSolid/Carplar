using Carplar.Shop.EntityFramework;
using Carplar.Shop.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Carplar.Shop.Repositories
{
    public class ShopRepository : BaseEfRepository, IShopRepository
    {
        public ShopRepository(Db context) : base(context) { }

        public IEnumerable<ShopItemVM> GetShopItems()
        {
            return Context.ShopItems.Select(si => new ShopItemVM());
        }
    }
}