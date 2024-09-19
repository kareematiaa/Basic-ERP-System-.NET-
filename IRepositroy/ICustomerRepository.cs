using Task1.Entities;

namespace Task1.IRepositroy;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAllCustomersAsync();
    Task<Customer> GetByIdAsync(int id);
}