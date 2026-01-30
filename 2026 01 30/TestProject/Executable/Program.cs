using Models;

internal static class Program
{
    internal static void Main(string[] args)
    {
        Developer NewDeveloper1 = new Developer();

        Console.Write("Developer's Name: ");
        NewDeveloper1.Name = Console.ReadLine();
        
        Console.WriteLine(NewDeveloper1.Name);
    }
}
