using System.Text;

namespace ATM_System;

public class ATM
{
    public string UserId;
    public string Pin;
    public int Balance;
    public bool IsLogged = false;

    public ATM(string id, string pin, int balance)
    {
        this.UserId = id;
        this.Pin = pin;
        this.Balance = balance;
    }

    public void LaunchApp()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Welcome. Please enter your PIN code:");
        Console.WriteLine("-------------------------------------");
        int LoginTry = 0;
        while(true)
        {
            string InputPinCode = Console.ReadLine();
            if(SignIn(InputPinCode))
            {
                break;
            }
            else
            {
                LoginTry++;
                Console.WriteLine($"Wrong PIN code {LoginTry}/3.");
                if(LoginTry >= 3)
                {
                    Exit();
                    return;
                };
            }
        };

        StringBuilder text = new StringBuilder();
        text.Append("ATM SYSTEM");
        text.Append("\n--------------");
        text.Append("\n\t1 → Balance");
        text.Append("\n\t2 → Withdraw");
        text.Append("\n\t3 → Deposit");
        text.Append("\n\t0 → Close");
        string menu = text.ToString();

        while(true)
        {
            Console.WriteLine(menu);
            string option = Console.ReadLine();

            if(option == "1")
            {
                ShowBalance();
            }
            else if(option == "2")
            {
                Console.Write("Withdraw amount: ");
                int input = int.Parse(Console.ReadLine());
                Withdraw(input);
            }
            else if(option == "3")
            {
                Console.Write("Deposit amount: ");
                int input = int.Parse(Console.ReadLine());
                Deposit(input);
            }
            else if(option == "0")
            {
                Exit();
                break;
            }
            else
            {
                Console.WriteLine("Wrong Input! Try menu options.");
            };
        };
    }
    public bool SignIn(string pin)
    {
        if(pin == this.Pin)
        {
            Console.WriteLine("Successfully logged in.");
            return true;
        }
        else
        {
            Console.WriteLine("Invalid credentials!");
            return false;
        }
    }
    public void ShowBalance()
    {
        if(IsLogged)
        {
            Console.WriteLine("Authorization required.");
        }
        else
        {
            Console.WriteLine($"Your balance: {this.Balance}");
        };
    }
    public void Withdraw(int amount)
    {
        if(IsLogged)
        {
            Console.WriteLine("Authorization required.");
        }
        else
        {
            if(this.Balance - amount >= 0)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($"Previous balance: {this.Balance}");
                Console.WriteLine($"Withdraw: -{amount}");
                this.Balance -= amount;
                Console.WriteLine($"Current balance: {this.Balance}");
            }
            else
            {
                Console.WriteLine("You have not enough balance.");
            };
        };
    }
    public void Deposit(int amount)
    {
        if(IsLogged)
        {
            Console.WriteLine("Authorization required.");
        }
        else
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"Previous balance: {this.Balance}");
            Console.WriteLine($"Deposit: +{amount}");
            this.Balance += amount;
            Console.WriteLine($"Current balance: {this.Balance}");
        };
    }
    public void Exit()
    {
        Console.WriteLine("Logged out.");
        this.IsLogged = false;
        return;
    }
};
