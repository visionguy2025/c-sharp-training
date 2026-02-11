namespace Entities;

public class Product:Base
{
    public string Title {get; set;}
    public int BrandId {get; set;}
    public Brand Brand {get; set;}
    public string Description {get; set;}
    public decimal Price {get; set;}
    public int CategoryId {get; set;}
    public Category Category {get ;set;}
}
