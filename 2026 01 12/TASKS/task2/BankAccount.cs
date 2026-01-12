namespace Work;

public class BankAccount
{
    public string Username;
    public string Password;
    public int Balance;
    public bool IsLogged=false;

    public BankAccount(string username)
    {
        this.Username = username;
    }
    public BankAccount(string username, string password):this(username)
    {
        this.Password = password;
    }
    public BankAccount(string username, string password, int balance):this(username, password)
    {
        this.Balance = balance;
    }

    public void Login()
    {
        Console.Write("Enter your username: ");
        string InputUsername = Console.ReadLine();
        Console.Write("Enter your password: ");
        string InputPassword = Console.ReadLine();

        if(InputUsername == this.Username && InputPassword == this.Password)
        {
            Console.WriteLine("You are successfully logged in.");
            this.IsLogged = true;
        }
        else
        {
            Console.WriteLine("Invalid credentials.");
        };
    }

    public void ShowBalance()
    {
        if(IsLogged)
        {
            Console.WriteLine($"Balance: {this.Balance}");
        }
        else
        {
            Console.WriteLine($"Authorization required. Please log in first.");
        };
    }
    public void Deposit(int DepositAmount=0)
    {
        if(IsLogged)
        {
            int PreviousAmount = this.Balance;
            this.Balance += DepositAmount;
            Console.WriteLine($"Current Balance: {PreviousAmount}");
            Console.WriteLine($"Deposit: +{DepositAmount}");
            Console.WriteLine($"Current Balance: {this.Balance}");
        }
        else
        {
            Console.WriteLine($"Authorization required. Please log in first.");
        };
    }
    public void Withdraw(int WithdrawAmount=0)
    {
        if(IsLogged && this.Balance - WithdrawAmount >= 0)
        {
            int PreviousAmount = this.Balance;
            this.Balance -= WithdrawAmount;
            Console.WriteLine($"Current Balance: {PreviousAmount}");
            Console.WriteLine($"Deposit: -{WithdrawAmount}");
            Console.WriteLine($"Current Balance: {this.Balance}");
        }
        else if(IsLogged && this.Balance - WithdrawAmount < 0)
        {
            Console.WriteLine($"You have not enough balance.");
        }
        else
        {
            Console.WriteLine($"Authorization required. Please log in first.");
        };
    }
};
