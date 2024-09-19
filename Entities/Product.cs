namespace Task1.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    
    public ICollection<OrderDetails>? OrderDetails { get; set; } 

}