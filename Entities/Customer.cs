namespace Task1.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FUllName { get; set; } = null!;
    public string Location { get; set; } = null!;
    
    public ICollection<OrderHeaders>? Orders { get; set; }

}