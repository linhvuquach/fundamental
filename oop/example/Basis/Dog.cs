namespace Basis;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hi I'm {Name}");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} is eating {food}.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating by Dog's foods.");
    }
}
