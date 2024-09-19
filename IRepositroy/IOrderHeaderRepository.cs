using Task1.Entities;

namespace Task1.IRepositroy;

public interface IOrderHeaderRepository
{
    Task AddAsync(OrderHeaders order);
}