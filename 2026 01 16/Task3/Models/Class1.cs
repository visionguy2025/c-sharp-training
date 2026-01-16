namespace Models;

public static class UserCounter
{
    private static int _TotalUsers
    {get; set;}

    public static void ShowCount()
    {
        Console.WriteLine($"■► Current Users Count: {_TotalUsers}");
    }
    public static void RegisterUser()
    {
        _TotalUsers++;
    }
};
