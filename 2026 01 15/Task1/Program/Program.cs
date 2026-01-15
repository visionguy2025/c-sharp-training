using ANIMALS;

internal static class Program
{
    internal static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        Cat cat1 = new Cat();

        Animal[] AnimalsArray = {dog1, cat1};

        foreach(Animal animal in AnimalsArray)
        {
            animal.Speak();
        };
    }
};
