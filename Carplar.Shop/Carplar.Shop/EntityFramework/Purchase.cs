namespace Carplar.Shop.EntityFramework
{
    public class Purchase : DbRecord
    {
        public int PurchaseId { get; set; }

        public int CustomerId { get; set; }

        public int ShipmentAddressId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PostalAddress ShipmentAddress { get; set; }
    }
}