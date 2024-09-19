using Microsoft.AspNetCore.Mvc;
using Task1.Dtos;
using Task1.IServices;

namespace Task1.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ICustomerService _customerService;
    private readonly IOrderHeaderService _orderHeaderService;
    private readonly IOrderDetailsService _orderDetailsService;

    public OrderController(IProductService productService,
        ICustomerService customerService, 
        IOrderHeaderService orderHeaderService , 
        IOrderDetailsService orderDetailsService)
    {
        _productService = productService;
        _customerService = customerService;
        _orderHeaderService = orderHeaderService;
        _orderDetailsService = orderDetailsService;
    }

    [HttpGet("GetAllProducts")]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _productService.GetAllProductsAsync();
        return Ok(products);
    }  
    
    [HttpGet("GetAllCustomers")]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await _customerService.GetAllCustomersAsync();
        return Ok(customers);
    }
    
    [HttpGet("{customerId}")]
    public async Task<IActionResult> GetCustomerById(int customerId)
    {
        var customer = await _customerService.GetCustomerByIdAsync(customerId);   


        if (customer == null)
        {
            return NotFound();
        }

        return Ok(customer);   

    }  
    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetProductById(int productId)
    {
        var product = await _productService.GetProductByIdAsync(productId);   


        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);   

    }
    
    [HttpPost]
    public async Task<IActionResult> CreateOrder(OrderHeaderDto orderHeaderDto)
    {
        try
        {
            var createdOrder = await _orderHeaderService.CreateOrderAsync(orderHeaderDto);
            return Ok("done");  
        }
  
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while creating the order: " + ex.Message);
        }
    }
}