namespace CoffeeTradePro.API.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }        
        public int SupplierId { get; set; }
        public decimal TotalAmount { get; private set; }
        public List<PurchaseItem> Items { get; set; } = new();
        public List<Payment> Payments { get; set; } = new();
        public void CalculateTotal()
        {
            TotalAmount = Items.Sum(i => i.Subtotal);
        }
    }
}
