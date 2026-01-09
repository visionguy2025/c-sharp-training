// TASK: 3 ededin ardicilligini yoxlayan method (2,5,8) -> true, (3,1,7) -> false
static void IsConsecurively(int[] arr)
{
    bool IsCorrect = true;
    for(int i=0; i<arr.Length; i++)
    {
        if(i != arr.Length - 1)
        {
            if(arr[i] > arr[i+1])
            {
                IsCorrect = false;
            };
        };
    };
    if(IsCorrect)
    {
        Console.WriteLine("Dogru: ardicildir");
    }
    else
    {
        Console.WriteLine("Yanlis: ardicil deyil");
    };
};

int[] values1 = new int[] {2,5,8};
int[] values2 = new int[] {3,1,7};

IsConsecurively(values1);
IsConsecurively(values2);
