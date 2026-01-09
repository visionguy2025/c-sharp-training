// TASK: istifadeciden bir eded alin reqemlerinin cemini tapin
static int SumDigits(int number)
{
    int sum = 0;
    while (true)
    {
        if(number % 10 <= 0)
        {
            sum += number;
            break;
        }
        else
        {
            sum = sum + (number % 10);
            number /= 10;
        }
    }
    return sum;
}

Console.WriteLine("Eded daxil edin: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------\nReqemlerinin cemi: " + SumDigits(input));
