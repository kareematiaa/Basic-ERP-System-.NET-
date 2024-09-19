using Microsoft.EntityFrameworkCore;
using Task1.Context;
using Task1.Entities;
using Task1.IRepositroy;

namespace Task1.Repository;

public class ProductRepository : IProductRepository
{
    private readonly TaskContext _db;
    public ProductRepository(TaskContext db) 
    {
        _db = db;
    }
    
    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _db.Products.ToListAsync();
    }
    
    public async Task<Product> GetByIdAsync(int id)
    {
        return await _db.Products
            .FirstAsync(o => o.Id == id); 
    }
}