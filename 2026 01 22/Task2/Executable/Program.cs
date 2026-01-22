using Models;
using Errors;

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
        MainMenu += "\n(0) Çıxış";

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
                    Console.Write("Kitabi icarededirse \"true\" yoxsa \"false\": ");
                    newBook.IsAvailable = bool.Parse(Console.ReadLine());
                    
                    Library.AddBook(newBook);
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Library.ListAllBooks();
                    break;
                case "6":
                    break;
                default:
                    return;
            }
        }
    }
}
