namespace Basis;

public abstract class Animal
{
    private readonly string _name;

    protected Animal(string name)
    {
        _name = name;
    }

    protected string Name => _name;

    public abstract void SayHello();

    public virtual void Eat()
    {
        Console.WriteLine($"{_name} is eating.");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{_name} is eating {food}.");
    }

    public static Animal operator +(Animal a1, Animal a2) => new CombinedAnimal($"{a1.Name} and {a2.Name}");
}

public class CombinedAnimal : Animal
{
    public CombinedAnimal(string name) : base(name)
    {
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hi, we are {Name}");
    }
}
