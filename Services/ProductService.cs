using AutoMapper;
using Task1.Dtos;
using Task1.IRepositroy;
using Task1.IServices;

namespace Task1.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository,IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> GetAllProductsAsync()
    {
        var products = await _productRepository.GetAllProductsAsync();
        return _mapper.Map<List<ProductDto>>(products);
    }
    
    public async Task<ProductDto> GetProductByIdAsync(int productId)
    {
        var product =  await _productRepository.GetByIdAsync(productId);   
        return _mapper.Map<ProductDto>(product);
    }
}