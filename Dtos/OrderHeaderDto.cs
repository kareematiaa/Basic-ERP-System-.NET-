namespace Task1.Dtos;

public class OrderHeaderDto
{
    public int CustomerId { get; set; }
    public double? Discount { get; set; }
    public double OrderTotal { get; set; }
    public List<OrderDetailsDto> OrderDetails { get; set; } = null!;

}