namespace Models;

public static class Utilities
{
    public static void AddToTeam(Employee emp)
    {
        // 
    }
    public static int CalculateDuration(Project proj)
    {
        // 
        return 0;
    }
    public static void PrintEmployeeInfo(Employee e)
    {
        // 
    }
    public static T[] ResizeArray<T>(T[] Array, int NewSize)
    {
        T[] NewArray = new T[NewSize];
        for(int i=0; i<Array.Length; i++)
        {
            if(i>=NewSize)
            {
                break;
            };
            NewArray[i] = Array[i];
        };
        return NewArray;
    }
};
