#region QUESTIONS
// 0. strings, arrays (C#)
// 1. compare
// 2. clone
// 3. copy
#endregion

#region STRING_BUILDER
// using System.Text;
// // Immutable
// string myString = "John";
// myString += " Doe"; // her defe yeni deyer yaradir
// Console.WriteLine(myString);
// // Mutable
// StringBuilder myString1 = new StringBuilder();
// myString1.Append("New");
// myString1.Append(" String");
// myString1.ToString();
// Console.WriteLine(myString1);
// // use your own custom methods instead ready methods, mostly not always
#endregion

#region STRING_METHODS
// string text = "   Hello World Lorem\tIpsum\nTEST";
// Console.WriteLine(text.Length);
// Console.WriteLine(text.StartsWith("He"));
// Console.WriteLine(text.StartsWith("Ha"));
// Console.WriteLine(text.EndsWith("suM"));
// Console.WriteLine(text.EndsWith("m Ipsum"));
// Console.WriteLine(text.IndexOf("W", text.IndexOf("W"))); // from first one, find all
// Console.WriteLine(text.IndexOf("o"));
// Console.WriteLine(text.LastIndexOf("o"));
// Console.WriteLine(text.Replace("o", "■"));
// Console.WriteLine(text.Remove(1, 4));
// Console.WriteLine(text.Substring(0, 5));
// string[] test = text.Split(" ");
// foreach(string word in test)
// {
//     Console.WriteLine(word);
// };
// Console.WriteLine(string.Join("*", test));
// string name1 = "abc";
// string name2 = "bc";
// Console.WriteLine(name1.CompareTo(name2)); // string.Compare(str1, st2)
// string name = "";
// if(string.IsNullOrEmpty(name))
// {
//     Console.WriteLine("True"); // its null or empty
// }
// else
// {
//     Console.WriteLine("False"); // its not empty
// };
#endregion

#region CASTING
// string n = "T";
// Console.WriteLine(n);
// Convert.ToInt32(n);
// Console.WriteLine(n);
#endregion

#region ARRAYS_RESIZE
// int[] numbers = new int[5];
// numbers[0] = 4;
// Console.WriteLine(numbers.Length);
// Array.Resize(ref numbers, 10); // ref because requires default value

// int [] MyResize(ref int[] array, int size)
// {
//     int[] newarray = new int[size];
//     for(int i=0; array.Length; i++)
//     {
//         newarray[i] = array[i];
//     };
//     newarray = array;
//     return newarray;
// };

// int[] numbers = {1,2,3,4,5,6,7,8,9};
// MyResize(ref numbers, 15);
// foreach(int number in numbers)
// {
//     Console.WriteLine(number);
// };
#endregion
