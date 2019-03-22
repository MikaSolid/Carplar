namespace Carplar.Shop.EntityFramework
{
    public class Payment : DbRecord
    {
        public int PaymentId { get; set; }

        public int PurchaseId { get; set; }

        public virtual Purchase Purchase { get; set; }
    }

}
