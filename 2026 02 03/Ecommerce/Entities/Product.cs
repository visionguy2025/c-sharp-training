namespace Entity;

public class Product
{
    public int Id {get; set;}
    public string Title {get; set;}
    public DateTime CreatedAt {get; set;}
    public int CategoryId {get; set;}
    public Category Category {get; set;}
}
