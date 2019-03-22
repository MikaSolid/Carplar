namespace Carplar.Shop.EntityFramework
{
    public class PurchaseItem : DbRecord
    {
        public int PurchaseItemId { get; set; }

        public int ShopItemId { get; set; }

        public virtual ShopItem ShopItem { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
