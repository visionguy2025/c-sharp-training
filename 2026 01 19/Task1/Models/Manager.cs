namespace Models;

public class Manager:Employee
{
    public override int Salary {get; set;}

    public override double CalculateBonus()
    {
        return 0.2 * Salary;
    }
};
