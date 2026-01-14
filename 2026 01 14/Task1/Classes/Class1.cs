namespace classes;

public class Person
{
    private string firstname;
    private string lastname;
    private int age;
    private string birthday;

    public string Firstname
    {
        get
        {
            return this.firstname;
        }
        set
        {
            if(value.Length > 2)
            {
                this.firstname = value;
            }
            else
            {
                Console.WriteLine("Firstname field requires minimum 3 symbols.");
            };
        }
    }
    public string Lastname
    {
        get
        {
            return this.lastname;
        }
        set
        {
            this.lastname = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if(value > 16)
            {
                this.age = value;
            }
            else
            {
                Console.WriteLine("Users can't be under 17 years old.");
            };
        }
    }
    public string BirthDay
    {
        get
        {
            return this.birthday;
        }
        set
        {
            this.birthday = value;
        }
    }

    // public void ShowDetails()
    // {
    //     Console.WriteLine($"Firstname: {this.firstname}");
    //     Console.WriteLine($"Lastname: {this.lastname}");
    //     Console.WriteLine($"Age: {this.age}");
    //     Console.WriteLine($"Birthday: {this.birthday}");
    // }
    // public void Register(string fname, string lname, int userage, string birthDay)
    // {
    //     this.firstname = fname;
    //     this.lastname = lname;
    //     this.age = userage;
    //     this.birthday = birthDay;
    // }
};
