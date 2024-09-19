using Task1.Dtos;
using Task1.Entities;

namespace Task1.IServices;

public interface IOrderHeaderService
{
    Task<OrderHeaders> CreateOrderAsync(OrderHeaderDto orderHeaderDto);
}