using Microsoft.EntityFrameworkCore;
using Task1.Context;
using Task1.Entities;
using Task1.IRepositroy;

namespace Task1.Repository;

public class OrderHeaderRepository : IOrderHeaderRepository
{
    private readonly TaskContext _db;
    public OrderHeaderRepository(TaskContext db) 
    {
        _db = db;
    }
    
    public async Task AddAsync(OrderHeaders order)
    {
        _db.Orders.Add(order);
        await _db.SaveChangesAsync();
    }
}