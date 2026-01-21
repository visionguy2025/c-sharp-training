using Models;

internal class Program
{
    internal static void Main(string[] args)
    {
        try
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            
            if(age <= 0)
            {
                throw new AgeException();
            }

            Human person1 = new Human()
            {
                Name=name,
                Surname=surname,
                Age=age
            };
        }
        catch(AgeException)
        {}
        catch(Exception AnotherErrors)
        {
            Console.WriteLine("An error occurred.");
            // Console.WriteLine(AnotherErrors);
        };
    }
};
