using AutoMapper;
using Task1.Dtos;
using Task1.Entities;
using Task1.IRepositroy;
using Task1.IServices;

namespace Task1.Services;

public class OrderHeaderService : IOrderHeaderService
{
    private readonly IOrderHeaderRepository _orderHeaderRepository;
    private readonly IMapper _mapper;

    public OrderHeaderService(IOrderHeaderRepository orderHeaderRepository, IMapper mapper)
    {
        _orderHeaderRepository = orderHeaderRepository;
        _mapper = mapper;
    }
    
    
    public async Task<OrderHeaders> CreateOrderAsync(OrderHeaderDto orderHeaderDto)
    {
        var orderHeader = _mapper.Map<OrderHeaders>(orderHeaderDto);
        await _orderHeaderRepository.AddAsync(orderHeader);
        return orderHeader;
    }
}

