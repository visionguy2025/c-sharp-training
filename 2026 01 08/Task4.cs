class Task4
{
    static void Main()
    {
        Console.WriteLine("Ededlerin muqayisesi:");
        Console.WriteLine("---------------------");
        Console.WriteLine("Birinci ededi daxil edin:");
        int value1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ikinci ededi daxil edin:");
        int value2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ucuncu ededi daxil edin:");
        int value3 = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------");
        Console.WriteLine("En boyuk eded: " + MaxValue(value1, value2, value3));
    }

    static int MaxValue(int a, int b, int c)
    {
        int biggest;
        return Math.Max(a, Math.Max(b, c));
    }
};
