using Models;

public static class Program
{
    public static void Main(string[] args)
    {
        int NewNumber = 10;
        Console.WriteLine(NewNumber.Add(10));
        Console.WriteLine(NewNumber.Subtract(7));
        Console.WriteLine(NewNumber.Multiply(3));
        Console.WriteLine(NewNumber.Divide(2));
        Console.WriteLine(NewNumber.Divide(0));
    }
};
