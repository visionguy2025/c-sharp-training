#region TESTS
// // array type
// dynamic[] test = {"text", 15};
// foreach(dynamic element in test)
// {
//     Console.WriteLine(element);
// };
// // object type
// var student = new
// {
//     Name="Abc",
//     Age=50
// };
#endregion

#region QUESTIONS
// .
#endregion

#region OOP
// using System;
// namespace HelloWorld
// {
//     public class Student
//     {
//         public string Firstname; // public string Firstname = "Lorem"; // default value for if user don't enter a value
//         public string Lastname;
//         public int Age;

//         public Student()
//         {
//             Console.WriteLine("Student has been created");
//         }
//         // public Student(string firstname, string lastname, int age)
//         // {
//         //     Firstname = firstname;
//         //     Lastname = lastname; // OR this.Lastname
//         //     Age = age;
//         // }
//         public Student(string firstname)
//         {
//             Firstname = firstname;
//         }
//         public Student(string firstname, string lastname):this(firstname)
//         {
//             Lastname = lastname;
//         }
//         public Student(string firstname, string lastname, int age):this(firstname, lastname)
//         {
//             Age = age;
//         }
//     };

//     static class Test
//     {
//         static void Main(string[] args)
//         {
//             Student student1 = new Student();
//             student1.Firstname = "Lorem";
//             student1.Lastname = "Ipsum";
//             student1.Age = 28;

//             Student student2 = new Student();
//             student2.Firstname = "Abc";
//             student2.Lastname = "Def";
//             student2.Age = 30;
            
//             Student student3 = new Student()
//             {
//                 Firstname = "A",
//                 Lastname = "B",
//                 Age = 55
//             };
            
//             Student student4 = new Student("Firstname", "Lastname", 100);

//             Student[] students = {student1, student2, student3, student4};

//             foreach(var student in students)
//             {
//                 Console.WriteLine(student.Firstname + " " + student.Lastname);
//             };

//             Student abc = new Student();
//             Console.WriteLine(abc.Age);
//         }
//     };
// };
#endregion
