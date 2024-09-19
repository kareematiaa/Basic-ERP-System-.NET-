using Microsoft.EntityFrameworkCore;
using Task1.Context;
using Task1.Entities;
using Task1.IRepositroy;

namespace Task1.Repository;

public class CustomerRepository : ICustomerRepository
{
    private readonly TaskContext _db;
    public CustomerRepository(TaskContext db) 
    {
        _db = db;
    }
    
    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        return await _db.Customers.ToListAsync();
    }
    
    public async Task<Customer> GetByIdAsync(int id)
    {
        return await _db.Customers
            .FirstAsync(o => o.Id == id); 
    }
}