using System.Text;

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
    public static List<Book>? SearchBooks(string keyword)
    {
        List<Book> ResultList = new List<Book>(0);
        foreach(Book element in Books)
        {
            if(element.Title.Contains(keyword))
            {
                ResultList.Add(element);
            }
        }
        if(ResultList.Count > 0)
        {
            return ResultList;
        }
        return null;
    }
    public static void ListAllBooks()
    {
        int bookCount = 0;
        StringBuilder allBooks = new StringBuilder();

        foreach(Book book in Books)
        {
            bookCount++;
            string BookDetails = "";
            BookDetails += $"#{bookCount}";
            BookDetails += " | Adi: " + book.Title;
            BookDetails += " | Muellif: " + book.Author;
            BookDetails += " | Il: " + book.Year;
            BookDetails += " | Movcuddur: " + book.IsAvailable + "\n";
            allBooks.Append(BookDetails);
        }
        Console.WriteLine($"====================\nMain Menu / All Books ({bookCount})\n====================");
        if(bookCount == 0)
        {
            Console.WriteLine("Kitab tapilmadi.\n");
        }
        else
        {
            Console.WriteLine(allBooks.ToString());
        }
    }
    public static void ListBorrowedBooks()
    {}
}
