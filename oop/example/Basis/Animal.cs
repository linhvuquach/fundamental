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
}
