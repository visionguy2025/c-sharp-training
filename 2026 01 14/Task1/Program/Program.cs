using Models.classes;

Person user1 = new Person();

// // user1.Firstname = "Lorem";
// user1.Firstname = "Lo";
// user1.Lastname = "Ipsum";
// // user1.Age = 30;
// user1.Age = 16;
// user1.BirthDay = "1996-01-14";
// Console.WriteLine(user1.Firstname);
// Console.WriteLine(user1.Lastname);
// Console.WriteLine(user1.Age);
// Console.WriteLine(user1.BirthDay);

// user1.Register("Lorem", "Ipsum", 30, "1996-01-14");
// user1.ShowDetails();

Console.Write("Your name: ");
user1.SetFirstname(Console.ReadLine());
Console.Write("Your surname: ");
user1.SetLastname(Console.ReadLine());
Console.Write("Your age: ");
user1.SetAge(int.Parse(Console.ReadLine()));
Console.Write("Your birthday: ");
user1.SetBirthday(Console.ReadLine());
Console.WriteLine("--------------------------------");
Console.WriteLine("--→ RESULT ←--");
Console.WriteLine($"Name: {user1.GetFirstname()}");
Console.WriteLine($"Surname: {user1.GetFirstname()}");
Console.WriteLine($"Age: {user1.GetAge()}");
Console.WriteLine($"Birthday: {user1.GetBirthday()}");
