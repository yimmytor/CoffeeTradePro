namespace CoffeeTradePro.API.Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string TaxId { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
