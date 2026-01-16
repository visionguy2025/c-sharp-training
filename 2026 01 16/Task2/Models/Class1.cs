namespace Models;

public static class MathHelper
{
    public static int Add(this int value, int addition)
    {
        return value + addition;
    }
    public static int Subtract(this int value, int decrement)
    {
        return value - decrement;
    }
    public static int Multiply(this int value, int multiplier)
    {
        return value * multiplier;
    }
    public static int Divide(this int value, int divider)
    {
        if(divider == 0)
        {
            Console.WriteLine("Divider can't equal to 0!");
            return value;
        }
        return value / divider;
    }
}
