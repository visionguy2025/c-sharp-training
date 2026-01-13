namespace Task1;

public class Cat:Animal
{
    public Cat(string name, int age):base(name, age)
    {}

    public void MakeSound()
    {
        Console.WriteLine("meow");
    }
};
