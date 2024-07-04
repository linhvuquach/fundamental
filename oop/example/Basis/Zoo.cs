namespace Basis;

public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void Add(Animal animal)
    {
        animals.Add(animal);
    }

    public void Remove(Animal animal)
    {
        animals.Remove(animal);
    }

    public void showAnimal()
    {
        foreach (var animal in animals)
        {
            animal.SayHello();
        }
    }
}
