// TASK: tek ve cut ededlerin sayini tapan metod
Counter(1,2,3,4,5,6,10,11,15,20,21);
static void Counter(params int[] list)
{
    int OddCount = 0;
    int EvenCount = 0;
    foreach(int element in list)
    {
        if(element % 2 == 0)
            EvenCount += 1;
        else
            OddCount += 1;
    };
    Console.Write("Tek ededlerin sayi: " + OddCount + ", Cut ededlerin sayi: " + EvenCount);
};
