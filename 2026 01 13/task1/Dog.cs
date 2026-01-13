namespace Task1;

public class Dog:Animal
{
    public Dog(string name, int age):base(name, age)
    {}

    public void MakeSound()
    {
        Console.WriteLine("haw");
    }
};
