using AutoMapper;
using Task1.Dtos;
using Task1.Entities;

namespace Task1.External;

public class MappingConfigration : Profile
{
    public MappingConfigration()
    {
        
        CreateMap<OrderHeaders, OrderHeaderDto>()
            .ReverseMap();   
        
        CreateMap<OrderDetails, OrderDetailsDto>()
            .ReverseMap();
        
        
        CreateMap<Customer, CustomerDto>()
            .ReverseMap();
        
        CreateMap<Product, ProductDto>()
            .ReverseMap();
    }

}