using Models;

internal static class Program
{
    internal static Employee[] employees;
    internal static Project[] projects;
    internal static Employee[] teams;

    internal static void Main(string[] args)
    {
        Application();
        // Teams[i].SecurityLevel > 5 ? Console.WriteLine("High") : Console.WriteLine("Low");
    }

    internal static void Application()
    {
        Manager manager = new Manager();
        employees = new Employee[0];
        projects = new Project[0];
        teams = new Employee[] {};

        bool IsRunning = true;

        while(IsRunning)
        {
            Console.WriteLine(":APPLICATION");
            Console.WriteLine("-----------------");
            Console.WriteLine("(1) → Employees");
            Console.WriteLine("(2) → Projects");
            Console.WriteLine("(0) → Close");
            Console.Write("Choose: ");
            string MainInput = Console.ReadLine();
            switch (MainInput)
            {
                case "1":
                    MenuEmployee();
                    break;
                case "2":
                    MenuProjects();
                    break;
                default:
                    Console.WriteLine("Application closed.");
                    return;
            }
        }
    }

    internal static void MenuEmployee()
    {
        Console.WriteLine(":APPLICATION/Employees");
        Console.WriteLine("------------------------");
        Console.WriteLine("(1) → Show all Employees");
        Console.WriteLine("(2) → Add new Employee");
        Console.WriteLine("(3) → Calculate Salary Bonus");
        Console.WriteLine("(4) → Create new Team");
        Console.WriteLine("(5) → Manage Teams");
        Console.WriteLine("(0) → Go back to Main Menu.");
        Console.Write("Choose: ");
        string EmployeeInput = Console.ReadLine();
        switch(EmployeeInput)
        {
            case "1":
                Console.WriteLine(":APPLICATION/Employees/All Employes");
                Console.WriteLine("------------------------");
                if(employees.Length == 0)
                {
                    Console.WriteLine("Not Employee found.");
                }
                else
                {
                    for(int i=0; i<employees.Length; i++)
                    {
                        Console.WriteLine(employees[i].GetFullName());
                    }
                }
                break;
            case "2":
                Console.WriteLine(":APPLICATION/Employees/Add Employee");
                Console.WriteLine("------------------------");
                int id = int.Parse(Console.ReadLine());
                string firstname = Console.ReadLine();
                string lastname = Console.ReadLine();
                int salary = int.Parse(Console.ReadLine());
                Employee NewEmployee = new Employee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    Salary = salary
                };
                break;
            case "3":
                Console.WriteLine(":APPLICATION/Employees/3");
                Console.WriteLine("------------------------");
                break;
            case "4":
                Console.WriteLine(":APPLICATION/Employees/4");
                Console.WriteLine("------------------------");
                break;
            case "5":
                Console.WriteLine(":APPLICATION/Employees/5");
                Console.WriteLine("------------------------");
                break;
            default:
                break;
        };
    }
    internal static void MenuProjects()
    {
        Console.WriteLine(":APPLICATION/Projects");
        Console.WriteLine("------------------------");
        Console.WriteLine("(1) → Show all Projects");
        Console.WriteLine("(2) → Create new Project");
        Console.WriteLine("(3) → Assign Team to Project");
        Console.WriteLine("(0) → Go back to Main Menu.");
        Console.Write("Choose: ");
        string ProjectsInput = Console.ReadLine();
        switch(ProjectsInput)
        {
            case "1":
                Console.WriteLine(":APPLICATION/Projects/1");
                Console.WriteLine("------------------------");
                break;
            case "2":
                Console.WriteLine(":APPLICATION/Projects/2");
                Console.WriteLine("------------------------");
                break;
            case "3":
                Console.WriteLine(":APPLICATION/Projects/3");
                Console.WriteLine("------------------------");
                break;
            default:
                break;
        };
    }
};
