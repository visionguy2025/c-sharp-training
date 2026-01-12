using Work;

// REGISTRATION
BankAccount person1 = new BankAccount("qwerty123", "a1", 1000);

// LOGIN
person1.Login();

// OTHER OPERATIONS
person1.ShowBalance();
person1.Deposit(500);
person1.ShowBalance();
person1.Withdraw(800);
person1.ShowBalance();

// OUT OF BALANCE TEST
person1.Withdraw(900);

// LOGIN FAILURE TEST
person1.Login();
person1.ShowBalance();
