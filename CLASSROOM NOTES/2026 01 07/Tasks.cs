#region task1
// Console.WriteLine("Eded daxil edin:");
// int limit = int.Parse(Console.ReadLine());
// for (int i = 1; i <= limit; i++)
// {
//     Console.WriteLine(i);
// };
#endregion

#region task2
// string password = "12345";
// bool isLoop = true;
// while (isLoop)
// {
//     Console.WriteLine("Sifreni daxil edin:");
//     string input = Console.ReadLine();
//     if (input == password)
//     {
//         Console.WriteLine("Giris ugurludur");
//         // break;
//         isLoop = false;
//     }
//     else
//     {
//         Console.WriteLine("Yanlis sifre, yeniden cehd edin!\n--------------------------");
//     };
// };
#endregion

#region task3
// int biggestValue;
// int a = 9;
// int b = 2;
// int c = 100;
// if(a>b)
// {
//     biggestValue = a;
// }
// else
// {
//     biggestValue = b;
// };

// if(biggestValue > c)
// {
//     Console.WriteLine($"En boyuk eded: {biggestValue}");
// }
// else
// {
//     Console.WriteLine($"En boyuk eded: ${c}");
// };
#endregion

#region task4
// Console.WriteLine("Bali daxil edin:");
int inputScore = int.Parse(Console.ReadLine());
switch (inputScore)
{
    case inputScore >= 91 && inputScore <= 100:
        Console.WriteLine("--------------------\nNetice: Ela");
        break;
    case inputScore >= 81 && inputScore <=90:
        Console.WriteLine("--------------------\nNetice: Yaxsi");
        break;
    case inputScore >= 71 && inputScore <=80:
        Console.WriteLine("--------------------\nNetice: Orta");
        break;
    case inputScore >= 61 && inputScore <=70:
        Console.WriteLine("--------------------\nNetice: Kafi");
        break;
    case inputScore >= 51 && inputScore <=60:
        Console.WriteLine("--------------------\nNetice: Zeif");
        break;
    default:
        Console.WriteLine("--------------------\nNetice: GG");
};
#endregion
