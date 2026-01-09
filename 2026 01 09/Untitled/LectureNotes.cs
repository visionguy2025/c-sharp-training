#region Some_Notes
// int.parse() or Convert.ToInt32()
// int number = 1;
// const float PI = 3.14;
#endregion

#region Research_Later
// RAM - stack (value), heap (reference)
#endregion

#region Memory
// Console.WriteLine("Hello World!");
int num = 10;
int num1 = num;
num= 20;
Console.WriteLine(num);
Console.WriteLine(num1);
// no bound, not reference type

int[] arr = {31, 24, 3, 4, 5};
int[] arr1 = arr;
arr1[0] = 32;
arr[1] = 25;
Console.WriteLine(arr);
Console.WriteLine(arr1);
// reference type, one of them change, both changes
#endregion

#region Recursive_Function
static int Factorial(int n)
{
    if(n <= 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n-1);
    };
};
#endregion

#region Reference_Value
// .
int number = 10;
number = ChangeValue(number);
Console.WriteLine(number);
static int ChangeValue(int number)
{
    number = 20;
    Console.WriteLine(number);
    return number;
};

// .
int number = 10;
ChangeValue(ref number);
Console.WriteLine(number);
static void ChangeValue(ref int number)
{
    number = 20;
    Console.WriteLine(number);
};

// .
int number;
ChangeValue(out number);
Console.WriteLine(number);
static void ChangeValue(out int number)
{
    number = 20;
    Console.WriteLine(number);
};
#endregion
