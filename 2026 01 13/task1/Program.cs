using Task1;

static class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog("Thor", 5);
        Cat cat1 = new Cat("Tiger", 3);
        dog1.MakeSound();
        cat1.MakeSound();
    }
};
