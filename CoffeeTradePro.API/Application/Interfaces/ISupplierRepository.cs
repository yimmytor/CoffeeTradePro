using CoffeeTradePro.API.Domain.Entities;

namespace CoffeeTradePro.API.Application.Interfaces
{
    public interface ISupplierRepository
    {
        Task<Supplier> GetByIdAsync(int Id);
        Task<IEnumerable<Supplier>> GetAllAsync();
    }
}
