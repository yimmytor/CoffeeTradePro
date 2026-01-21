namespace CoffeeTradePro.API.Domain.Entities
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => Quantity * UnitPrice;
    }
}
