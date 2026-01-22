namespace Models;

public static class Library
{
    public static List<Book> Books = new List<Book>(0);
    public static List<User> Users = new List<User>(0);

    public static void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine("====================\nMain Menu / Add New Book\n====================\nYeni kitab ugurla elave edildi.");
    }
    public static void RemoveBook(Guid bookId)
    {}
    public static void RegisterUser(User user)
    {}
    public static void BorrowBook(Guid userId, Guid bookId)
    {}
    public static void ReturnBook(Guid userId, Guid bookId)
    {}
    // public List<Book> SearchBooks(string keyword)
    // {
    //     return;
    // }
    public static void ListAllBooks()
    {
        int bookCount = 0;
        Console.WriteLine("====================\nMain Menu / All Books\n====================");
        foreach(Book book in Books)
        {
            bookCount++;
            string BookDetails = "";
            BookDetails += "Adi: " + book.Title;
            BookDetails += " | Muellif: " + book.Author;
            BookDetails += " | Il: " + book.Year;
            BookDetails += " | Movcuddur: " + book.IsAvailable;
            Console.WriteLine(BookDetails);
        }
        if(bookCount == 0)
        {
            Console.WriteLine("Kitab tapilmadi.");
        }
    }
    public static void ListBorrowedBooks()
    {}
}
