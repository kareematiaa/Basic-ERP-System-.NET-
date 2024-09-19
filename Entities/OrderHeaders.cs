namespace Task1.Entities;

public class OrderHeaders
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public double? Discount { get; set;}
    public double OrderTotal { get; set; }
    
    // Navigation Properties
    public Customer Customer { get; set; } = null!;
    public ICollection<OrderDetails>? OrderDetails { get; set;} 
}