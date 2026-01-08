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
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();
           int result = calculator.Divide(10, 2);
           Console.WriteLine(result);
        }

        // signature of the method - methods name, methods parameter count, methods parameter return type
        // overload of methods

        static void GetInfo(int age)
        {
            Console.WriteLine("Salam");
        }
        static void GetInfo(string name)
        {
            Console.WriteLine("Salam");
        }
        static void GetInfo(string name, int age)
        {
            Console.WriteLine("Salam");
        }
    };

    public class Calculator {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    };
};
#endregion
