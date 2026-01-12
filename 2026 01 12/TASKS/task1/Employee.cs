namespace Helloworld;

public class Employee
{
    public string Fullname;
    public string Position;
    public int Salary;

    public Employee(string fullname, string position, int salary)
    {
        this.Fullname = fullname;
        this.Position = position;
        this.Salary = salary;
    }

    public void IncreaseSalary(int raise)
    {
        this.Salary = this.Salary + (raise * this.Salary / 100);
    }
    public void GetBalance()
    {
        Console.WriteLine($"Employee: {this.Fullname} | Position: {this.Position} | Salary: {this.Salary}");
    }
};
