class Task3
{
    static void Main()
    {
        OddOrEven(1, 2, 3, 4, 5, 10, 11, 99, 100, 151, 7, 8);
    }

    static void OddOrEven(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine(number + " is even");
            }
            else
            {
                Console.WriteLine(number + " is odd");
            }
            ;
        }
    }
};
