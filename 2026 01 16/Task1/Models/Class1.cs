namespace models;

public static class Calculator
{
    public static int Power(this int number, int power)
    {
        int result = number;
        for(int i=1; i<power; i++)
        {
            result *= number;
        };
        return result;
    }
};
