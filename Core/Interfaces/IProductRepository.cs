using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProduct(int id);
        Task<IReadOnlyList<Product>> GetProducts();
    }
}