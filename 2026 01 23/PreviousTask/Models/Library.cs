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
    {
        foreach(Book element in Books)
        {
            if(element.Id == bookId)
            {
                Console.WriteLine("Kitab silindi.\n");
                Books.Remove(element);
                return;
            }
        }
        Console.WriteLine("Axtarilan kitab movcud deyil.\n");
    }
    public static void RegisterUser(User user)
    {
        Users.Add(user);
        Console.WriteLine("====================\nMain Menu / User Registration\n====================\nYeni istifadeci ugurla elave edildi.");
    }
    public static void BorrowBook(Guid userId, Guid bookId)
    {
        bool DoesUserExist = false;
        bool DoesBookExist = false;
        User SelectedUser = new User();
        Book SelectedBook = new Book();
        foreach(User user in Users)
        {
            if(user.Id == userId)
            {
                SelectedUser = user;
                DoesUserExist = true;
                break;
            }
        }
        foreach(Book book in Books)
        {
            if(book.Id == bookId)
            {
                SelectedBook = book;
                DoesBookExist = true;
                break;
            }
        }
        if(!DoesUserExist)
        {
            // throw error
            return;
        }
        if(!DoesBookExist)
        {
            // throw error
            return;
        }
        if(SelectedUser.BorrowedBooks.Contains(SelectedBook))
        {
            // throw error
            return;
        }
        if(!SelectedBook.IsAvailable)
        {
            // throw error
            return;
        }
        SelectedUser.BorrowedBooks.Add(SelectedBook);
        SelectedBook.IsAvailable = false;
        Console.WriteLine($"Kitab ({SelectedBook.Title}) daxil edilen istifadeciye icareye verildi.");
    }
    public static void ReturnBook(Guid userId, Guid bookId)
    {
        bool DoesUserExist = false;
        bool DoesBookExist = false;
        User SelectedUser = new User();
        Book SelectedBook = new Book();
        foreach(User user in Users)
        {
            if(user.Id == userId)
            {
                SelectedUser = user;
                DoesUserExist = true;
                break;
            }
        }
        foreach(Book book in Books)
        {
            if(book.Id == bookId)
            {
                SelectedBook = book;
                DoesBookExist = true;
                break;
            }
        }
        if(!DoesUserExist)
        {
            // throw error
            return;
        }
        if(!DoesBookExist)
        {
            // throw error
            return;
        }
        if(!SelectedUser.BorrowedBooks.Contains(SelectedBook))
        {
            // throw error
            return;
        }
        if(SelectedBook.IsAvailable)
        {
            // throw error
            return;
        }
        SelectedUser.BorrowedBooks.Remove(SelectedBook);
        SelectedBook.IsAvailable = true;
        Console.WriteLine($"Kitab ({SelectedBook.Title}) geri qaytarildi.");
    }
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
            BookDetails += $"ID: {book.Id}";
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
    {
        int bookCount = 0;
        StringBuilder rentedBooks = new StringBuilder();

        foreach(Book book in Books)
        {
            if(book.IsAvailable == false)
            {
                bookCount++;
                string BookDetails = "";
                BookDetails += $"ID: {book.Id}";
                BookDetails += " | Adi: " + book.Title;
                BookDetails += " | Muellif: " + book.Author;
                BookDetails += " | Il: " + book.Year;
                BookDetails += " | Movcuddur: " + book.IsAvailable + "\n";
                rentedBooks.Append(BookDetails);
            }
        }
        Console.WriteLine($"====================\nMain Menu / Rented Books ({bookCount})\n====================");
        if(bookCount == 0)
        {
            Console.WriteLine("Icarede kitab yoxdur.\n");
        }
        else
        {
            Console.WriteLine(rentedBooks.ToString());
        }
    }
}
