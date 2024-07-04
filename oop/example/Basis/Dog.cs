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
}
