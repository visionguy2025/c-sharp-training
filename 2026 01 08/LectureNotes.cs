#region Questions
// - 1. is there async methods in C#;
// + 2. is there default value for parameters in C#
#endregion

#region Functions&Methods
// // string ProductName; // correct name convenction in C#, Pascal case
// // when - research (switch case)

// modifier return-type name(int x, string y) {
//    return x;
// };

// Console.WriteLine(GetName("Lorem"));
// Console.WriteLine(GetFullName("Lorem", "Ipsum"));
// static string GetName(string name)
// {
//     return name;
// };
// static string GetFullName(string name, string surname)
// {
//     return name + " " + surname;
// };

// // if method doesnt returns any value, set return type void
// static void ConsoleMessage(string message)
// {
//     Console.WriteLine(message);
// };
// ConsoleMessage("Hello World");
// // even inside void method, if you want to prevent next lines, can be added return; like break; maybe because it returns nothing

// (int, string, int) info1 = (1996, "Orxan", 30); // tuple type
// (int year, string name, int age) info2 = (1996, "Orxan", 30);

// // parameters which has default value(s) must be on end
// static string GetText(string prefix, string text="Empty")
// {
//     return prefix + " " + text;
// };
// Console.WriteLine(GetText("Test "));
#endregion

#region Class
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//            Calculator calculator = new Calculator();
//            int result = calculator.Divide(10, 2);
//            Console.WriteLine(result);
//         }

//         // signature of the method - methods name, methods parameter count, methods parameter return type
//         // overload of methods

//         static void GetInfo(int age)
//         {
//             Console.WriteLine("Salam");
//         }
//         static void GetInfo(string name)
//         {
//             Console.WriteLine("Salam");
//         }
//         static void GetInfo(string name, int age)
//         {
//             Console.WriteLine("Salam");
//         }
//     };

//     public class Calculator {
//         public int Sum(int a, int b)
//         {
//             return a + b;
//         }
//         public int Sub(int a, int b)
//         {
//             return a - b;
//         }
//         public int Multiply(int a, int b)
//         {
//             return a * b;
//         }
//         public int Divide(int a, int b)
//         {
//             return a / b;
//         }
//     };
// };
#endregion

#region BuiltInMath
// using System;
// namespace HelloWorld
// {
//     class LectureNotes
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(Math.Abs(-56));
//             Console.WriteLine(Math.Sqrt(64));
//             Console.WriteLine(Math.Pow(9, 3));
//         }
//     };
// };
#endregion

#region Arrays
// namespace Name
// {
//     class Untitled
//     {
//         static void Main(string[] args)
//         {
//             string[]names = {"Alice", "Bob", "Charlie", "Diana"};
//             // foreach (string name in names)
//             // {
//             //     Console.WriteLine(name);
//             // };
//             for (int i=0; i<names.Length; i++)
//             {
//                 Console.WriteLine(names[i]);
//             }

//             int[] numbers = {1, 2, 3, 4, 5};
//             Console.WriteLine(SumArrElements(numbers));
//             Console.WriteLine(SumArrElements(new int[] {6,7,8,9}));
//             // if function would accept parameters as this - params int[] array, we could send arguments without array - SumArrElements(5, 10, 100, 150, 20)
//         }
//         static int SumArrElements(int[] arrs)
//         {
//             int sum = 0;
//             foreach(int element in arrs)
//             {
//                 sum += element;
//             };
//             return sum;
//         }
//     };
// };
#endregion
