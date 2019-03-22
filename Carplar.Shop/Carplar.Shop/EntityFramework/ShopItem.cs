using System;

namespace Carplar.Shop.EntityFramework
{
    public class ShopItem : DbRecord
    {
        public int ShopItemId { get; set; }

        public int ArticleId { get; set; }

        public DateTime Created { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public virtual Article Article { get; set; }
    }
}