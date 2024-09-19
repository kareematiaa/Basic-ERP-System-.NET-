using Task1.Entities;

namespace Task1.IRepositroy;

public interface IProductRepository
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product> GetByIdAsync(int id);
}