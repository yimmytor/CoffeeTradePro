using CoffeeTradePro.API.Domain.Entities;

namespace CoffeeTradePro.API.Application.Interfaces
{
    public interface IPurchaseService
    {
        Task<Purchase?> CreatePurchaseAsync(Purchase purchase);
    }
}
