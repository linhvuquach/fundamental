using System;

namespace Company.ClassLibrary1;

// Violates ISP
public interface IWoker
{
    void Work();
    void Eat();
    void Sleep();
}

// Follow ISP
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class Human : IWorkable, IEatable, ISleepable
{
    public void Work()
    {
        // Human work
    }

    public void Eat()
    {
        // Human eat
    }

    public void Sleep()
    {
        // Human sleep
    }
}

public class Robot : IWorkable
{
    public void Work()
    {
        // Robot work
    }
}