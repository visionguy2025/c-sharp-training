using MyModels;

internal class Program
{
    internal static void Main(string[] args)
    {
        MyList<int> numbers = new MyList<int>();
        numbers.Add(10);
        numbers.Add(3);
        numbers.Clear();
        numbers.Add(852);
        numbers.Add(1);
        // numbers.Remove(852);
        numbers.Add(2026);
        numbers.Add(50);
        // Console.WriteLine(numbers.Contains(50));
        // Console.WriteLine(numbers.Contains(51));
        numbers.Add(999);
        Console.WriteLine(numbers.Count());
        
        foreach(int number in numbers.NewList)
        {
            Console.WriteLine(number);
        }
    }
}
