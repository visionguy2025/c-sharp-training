namespace Models;

public class User
{
    public Guid Id = Guid.NewGuid();
    public string Name {get; set;}
    public List<Book> BorrowedBooks = new List<Book>(0);
}
