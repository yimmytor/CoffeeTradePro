namespace CoffeeTradePro.API.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }
}
