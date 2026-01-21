namespace Models;

public class AgeException:Exception
{
    public AgeException()
    {
        Console.WriteLine("Invalid age input!");
    }
}
