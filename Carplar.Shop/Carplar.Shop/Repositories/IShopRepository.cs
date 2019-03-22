using Carplar.Shop.ViewModels;
using System.Collections.Generic;

namespace Carplar.Shop.Repositories
{
    public interface IShopRepository {
        IEnumerable<ShopItemVM> GetShopItems();
    }
}