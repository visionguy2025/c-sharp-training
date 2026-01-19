namespace Models;

public abstract class Employee:Person
{
    public override int Id {get; set;}
    public override string FirstName {get; set;}
    public override string LastName {get; set;}
    public abstract int Salary {get; set;}

    public virtual double CalculateBonus()
    {
        return 0.1 * Salary;
    }
};
