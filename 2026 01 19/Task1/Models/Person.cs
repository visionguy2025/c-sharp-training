namespace Models;

public abstract class Person
{
    public abstract int Id {get; set;}
    public abstract string FirstName {get; set;}
    public abstract string LastName {get; set;}

    public virtual string GetFullName()
    {
        return FirstName + " " + LastName;
    }
};
