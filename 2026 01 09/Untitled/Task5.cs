// TASK: massiv teyin edin, massiv ededlerin orta qiymetini hesablayan metod
static float FindAverage(int[] arr)
{
    float sum = 0;
    int count = arr.Length;
    float average;

    foreach(int number in arr)
    {
        sum += number;
    };

    average = sum / count;
    return average;
};
float result = FindAverage(new int[] {10, 50, 100, 200, 40});
Console.WriteLine("Result: " + result);
