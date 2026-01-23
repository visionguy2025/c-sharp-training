namespace Models;

public class Book
{
    public Guid Id = Guid.NewGuid();
    public string Title {get; set;}
    public string Author {get; set;}
    public int Year {get; set;}
    public bool IsAvailable {get; set;}
}
