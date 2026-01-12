using Helloworld;

Employee employee1 = new Employee("John Smith", "HR", 1100);
Employee employee2 = new Employee("Lorem Ipsum", "Developer", 1300);

Employee[] employers = {employee1, employee2};

foreach(var employee in employers)
{
    if(employee.Position == "HR")
    {
        employee.IncreaseSalary(10);
        employee.GetBalance();
    }
    else if(employee.Position == "Developer")
    {
        employee.IncreaseSalary(20);
        employee.GetBalance();
    };
};
