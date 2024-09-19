using Task1.Context;
using Task1.IRepositroy;

namespace Task1.Repository;

public class OrderDetailsRepository : IOrderDetailsRepository
{
    private readonly TaskContext _db;
    public OrderDetailsRepository(TaskContext db) 
    {
        _db = db;
    }
    
}