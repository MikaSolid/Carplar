using System;

namespace Carplar.Shop.EntityFramework
{
    public class Shipment : DbRecord
    {
        public int ShipmentId { get; set; }

        public int PurchaseId { get; set; }

        public DateTime? Shipped { get; set; }

        public DateTime? EstimatedArrival { get; set; }

        public virtual Purchase Purchase { get; set; }
    }
}