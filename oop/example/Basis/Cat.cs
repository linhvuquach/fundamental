namespace Basis;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hi I'm {Name}");
    }
}
