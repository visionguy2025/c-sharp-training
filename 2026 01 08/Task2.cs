class Task2
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(Greet(input));
    }

    static string Greet(string name)
    {
        return "Welcome" + " " + name + ".";
    }
};
