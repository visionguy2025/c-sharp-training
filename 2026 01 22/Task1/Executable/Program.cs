using System.Security.Cryptography;
using Models;

internal class Program
{
    internal static void Main(string[] args)
    {
        // create empty MyList value
        MyList<int> RandomValuesList = new MyList<int>();

        // generate 10 random values
        for (int i=0; i<RandomValuesList.Length(); i++)
        {
            RandomValuesList.AddNewRandom(RandomNumberGenerator.GetInt32(1000));
        }

        // output
        RandomValuesList.Length();
        RandomValuesList.FindMin();
        RandomValuesList.FindMiddle();
        RandomValuesList.FindMax();
        RandomValuesList.ShowAll();
    }
}
