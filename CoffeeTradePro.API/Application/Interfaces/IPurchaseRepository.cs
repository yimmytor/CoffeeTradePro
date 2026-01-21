using CoffeeTradePro.API.Domain.Entities;

namespace CoffeeTradePro.API.Application.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<Purchase> GetByIdAsync(int id);
        Task AddAsync(Purchase purchase);
    }
}
