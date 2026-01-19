using Models;

internal class Program
{
    internal static void Main(string[] args)
    {
        Application();
        // Teams[i].SecurityLevel > 5 ? Console.WriteLine("High") : Console.WriteLine("Low");
    }

    internal static void Application()
    {
        Manager manager = new Manager();
        Employee[] Employees = new Employee[0];
        Project[] Projects = new Project[0];
        Employee[] Teams = new Employee[] {};

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
                    MenuEmployee(Employees);
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

    internal static void MenuEmployee(Employee[] EmployeeList)
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
                if(EmployeeList.Length == 0)
                {
                    Console.WriteLine("Not Employee found.");
                }
                else
                {
                    for(int i=0; i<EmployeeList.Length; i++)
                    {
                        Console.WriteLine(EmployeeList[i].GetFullName());
                    }
                }
                break;
            case "2":
                Console.WriteLine(":APPLICATION/Employees/2");
                Console.WriteLine("------------------------");
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
