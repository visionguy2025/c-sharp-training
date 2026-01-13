using ATM_System;

static class Program
{
    static void Main(string[] args)
    {
        ATM NewAccount1 = new ATM("user_01", "1234", 2000);
        NewAccount1.LaunchApp();
    }
};
