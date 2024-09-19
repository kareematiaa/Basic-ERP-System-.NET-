namespace Task1.Entities;

public class OrderDetails
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal ProductPrice { get; set; }
    
    // Navigation Properties
    public OrderHeaders OrderHeaders { get; set; } = null!;
    public Product Product { get; set; } = null!;
}