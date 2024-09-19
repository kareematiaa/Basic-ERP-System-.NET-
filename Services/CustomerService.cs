using AutoMapper;
using Task1.Dtos;
using Task1.IRepositroy;
using Task1.IServices;

namespace Task1.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }
    
    public async Task<List<CustomerDto>> GetAllCustomersAsync()
    {
        var customers = await _customerRepository.GetAllCustomersAsync();
        return _mapper.Map<List<CustomerDto>>(customers);
        
    }
    
    public async Task<CustomerDto> GetCustomerByIdAsync(int customerId)
    {
        var customer =  await _customerRepository.GetByIdAsync(customerId);   
        return _mapper.Map<CustomerDto>(customer);
    }
}