///
/// We create an Abstract Class called "Animal" that represents any type of animal and has a method called "sayHello()" to demonstrate Abstraction.
///
/// The classes "Cat" and "Dog" inherit from the "Animal" class. 

/// They override the "sayHello()" method according to their own way of greeting. 
/// This demonstrates Encapsulation, as it encapsulates the specific behavior of each animal within their respective classes.
/// It also encapsulates the variable name and the "sayHello()" method together. 
/// Now, let's say we have a Zoo. In the Zoo, we have various animals, such as cats and dogs.
///
/// We can call the "sayHello()" method on each animal in the Zoo. 
/// However, each animal will make a different sound when they greet. 
/// This showcases Polymorphism, as the same method name "sayHello()" is invoked, but it behaves differently depending on the type of animal, allowing for flexible and varied behavior.

using Basis;

Cat Jerry = new Cat("Jerry");
Dog Mia = new Dog("Mia");

Zoo zoo = new Zoo();
zoo.Add(Jerry);
zoo.Add(Mia);

zoo.showAnimal();