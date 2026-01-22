using System.Security.Cryptography;

namespace Models;

public class MyList<T>
{
    public List<T> list = new List<T>(0);

    public void AddNewRandom(T value)
    {
        list.Add(value);
    }
    public int Length()
    {
        return list.Count;
    }
    public void ShowAll()
    {
        Console.WriteLine(list.Count);
        for(int i=0; i<list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
    public void FindMin()
    {
        int min = 0;
        for(int i=0; i<list.Count; i++)
        {
            if(list[i] < min)
            {
                min = list[i];
            }
        }
        Console.WriteLine(min);
    }
    public void FindMiddle()
    {
        int middle = 0;
        for(int i=0; i<list.Count; i++)
        {
            middle += list[i];
        }
        middle /= list.Count;
        Console.WriteLine(middle);
    }
    public void FindMax()
    {
        int max = 0;
        for(int i=0; i<list.Count; i++)
        {
            if(list[i] > max)
            {
                max = list[i];
            }
        }
        Console.WriteLine(max);
    }
}
