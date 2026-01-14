namespace Models;

public class Person
{
    private string username;
    private string password;
    private string firstname;
    private string lastname;
    private string dateofbirth;
    private int age;

    public string Username
    {
        get
        {
            return;
        }
        set
        {
            username = value;
        }
    }
    public string Password
    {
        get
        {
            return;
        }
        set
        {
            password = value;
        }
    }
    public string Firstname
    {
        get
        {
            return;
        }
        set
        {
            firstname = value;
        }
    }
    public string Lastname
    {
        get
        {
            return;
        }
        set
        {
            lastname = value;
        }
    }
    public string DateOfBirth
    {
        get
        {
            return;
        }
        set
        {
            dateofbirth = value;
        }
    }
    public int Age
    {
        get
        {
            return;
        }
        set
        {
            age = value;
        }
    }
};

Person NewUser1 = new Person();

NewUser1.Username = "";
NewUser1.Password = "";
NewUser1.Firstname = "";
NewUser1.Lastname = "";
NewUser1.DateOfBirth = "";
NewUser1.Age = 0
