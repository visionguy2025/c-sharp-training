class Task1
{
    static void Main()
    {
        Console.WriteLine("Eded daxil edin:\n--------------------");
        int InputNumber = int.Parse(Console.ReadLine());
        int factorial = CalculateFactorial(InputNumber);
        Console.WriteLine(factorial);
    }

    static int CalculateFactorial(int number=0)
    {
        int result = 1;
        int max = Math.Abs(number);
        for(int i=1; i<=max; i++)
        {
            result *= i;
        };
        return result;
    }
};
