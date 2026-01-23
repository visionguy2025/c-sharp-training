using Models;
using Errors;
using System.ComponentModel;

internal class Program
{
    internal static void Main(string[] args)
    {
        Application();
    }

    internal static void Application()
    {
        string MainMenu = "====================\nMain Menu /\n====================";
        MainMenu += "\n(1) Kitab əlavə et";
        MainMenu += "\n(2) İstifadəçi qeydiyyat";
        MainMenu += "\n(3) Kitab icarəyə götür";
        MainMenu += "\n(4) Kitab qaytar";
        MainMenu += "\n(5) Bütün kitabları göstər";
        MainMenu += "\n(6) Axtarış";
        MainMenu += "\n(7) Kitab sil";
        MainMenu += "\n(8) Icarede olan kitablari goster";
        MainMenu += "\n(0) Çıxış" + "\n";

        while(true)
        {
            Console.WriteLine(MainMenu);
            Console.Write("Sec: ");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Book newBook = new Book();

                    Console.Write("Kitabin adini daxil edin: ");
                    newBook.Title = Console.ReadLine();
                    Console.Write("Kitabin muellifinin adini daxil edin: ");
                    newBook.Author = Console.ReadLine();
                    Console.Write("Kitabin ilini daxil edin: ");
                    newBook.Year = int.Parse(Console.ReadLine());
                    Console.Write("Kitabi icarededirse \"false\" yoxsa \"true\": ");
                    newBook.IsAvailable = bool.Parse(Console.ReadLine());
                    
                    Library.AddBook(newBook);
                    break;
                case "2":
                    User newUser = new User();

                    Console.Write("Adinizi daxil edin: ");
                    newUser.Name = Console.ReadLine();
                    
                    Library.RegisterUser(newUser);
                    break;
                case "3":
                    Console.WriteLine("====================\nMain Menu / Borrow Book\n====================");
                    if(Library.Users.Count > 0 && Library.Books.Count > 0)
                    {
                        Console.WriteLine("Current Users:");
                        foreach(User user in Library.Users)
                        {
                            Console.WriteLine($"ID: {user.Id} | Name: {user.Name}");
                        }
                        Console.Write("Istifadeci ID-si daxil edin: ");
                        Guid SelectedUserId = new Guid(Console.ReadLine());
                        Console.Write("Kitabin ID-sini daxil edin: ");
                        Guid SelectedBookId = new Guid(Console.ReadLine());
                        Library.BorrowBook(userId:SelectedUserId, bookId:SelectedBookId);
                    }
                    else
                    {
                        Console.WriteLine("Istifadeci ve ya tapilmadi.\n");
                    }
                    break;
                case "4":
                    Console.WriteLine("====================\nMain Menu / Return Book\n====================");
                    if(Library.Users.Count > 0 && Library.Books.Count > 0)
                    {
                        Console.WriteLine("Current Users:");
                        foreach(User user in Library.Users)
                        {
                            Console.WriteLine($"ID: {user.Id} | Name: {user.Name}");
                        }
                        Console.Write("Istifadeci ID-si daxil edin: ");
                        Guid SelectedUserId = new Guid(Console.ReadLine());
                        Console.Write("Kitabin ID-sini daxil edin: ");
                        Guid SelectedBookId = new Guid(Console.ReadLine());
                        Library.ReturnBook(userId:SelectedUserId, bookId:SelectedBookId);
                    }
                    else
                    {
                        Console.WriteLine("Istifadeci ve ya tapilmadi.\n");
                    }
                    break;
                    break;
                case "5":
                    Library.ListAllBooks();
                    break;
                case "6":
                    Console.WriteLine("====================\nMain Menu / Search Book\n====================");
                    Console.Write("Axtar: ");
                    List<Book> result = Library.SearchBooks(Console.ReadLine());
                    if(result != null)
                    {
                        foreach(Book book in result)
                        {
                            Console.WriteLine("→ ID: " + book.Id + " | " + book.Title);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Netice tapilmadi.\n");
                    }
                    break;
                case "7":
                    Console.WriteLine("====================\nMain Menu / Remove Book\n====================");
                    Console.Write("Silmek istediyiniz kitabin GUID-sini daxil edin: ");
                    Guid SearchInput = new Guid(Console.ReadLine());
                    Library.RemoveBook(SearchInput);
                    break;
                case "8":
                    Library.ListBorrowedBooks();
                    break;
                case "0":
                    Console.WriteLine("====================\nApplication closed.\n====================\n");
                    return;
                default:
                    Console.WriteLine("\n Invalid input! Please try 1-6 or 0.");
                    break;
            }
        }
    }
}
