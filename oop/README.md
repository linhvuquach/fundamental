# Object Oriented Programming

OOP is an approach to programming that uses Objects to build software and application.

## 5 concepts in OOP

1. Class

In OOP, a Class represents a collection of OBJECTS that share common characteristics, behaviors, and operational methods.

- The characteristics of an object are called fields.
- The external representation of object characteristics is achieved through class properties.
- The behaviors and operational methods of an object are called methods of the class.

2. Method

A method represents the behavior and operational methods of an object.

3. Field

A field refers to the variables of a class, also known as (aka) global variables. Fields are used to store the data of an Object.

Fields should use the "Private" modifier to restrict access to them from within the class. If we want to access fields from outside the class, we use properties.

4. Property

Properties provide a flexible mechanism for using the fields of a class.

A property has two special methods called accessors: get and set.

```c#
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
```

5. Object

An Object is a real-world entity with characteristics and behaviors.

In C#, an Object is an instance of a class.

A class represents a collection of objects with common properties. When you initialize an instance of a class, it becomes an object.

## 4 properties in OOP

1. Encapsulation

Encapsulation is the ability to hide the information of an OBJECT from the outside environment.

This characteristic ensures the integrity and security of an OBJECT. Encapsulation is represented through modifier keywords: public, private, protected, internal, protected internal.

2. Inheritance

Inheritance is the ability to create a new class based on an existing class. The **derived class** inherits members defined by the **base class**.

3. Polymorphism

Polymorphism is the ability of an OBJECT to perform a task in different ways.

Polymorphism allows objects of different classes to be treated as objects of a common superclass. This promotes flexibility and extensibility in the design.

Type Polymorphism: Overloading, Overriding

### Overloading (static polymorphism)

Overloading is static polymorphism that occurs at compile time.

C# provides two techniques for Overloading:

- Method Overloading: Methods with the same name but different numbers and/or types of parameters.
- Operator Overloading: You can redefine or overload most of the built-in operators in C#. Thus, you can use operators with user-defined types.

### Overriding (dynamic polymorphism)

Overriding is dynamic polymorphism that occurs at runtime.

Dynamic polymorphism is implemented through abstract classes and virtual functions.

4. Abstraction

Identifying the relevant entities(objects) in the problem domain and abstracting thier essential characteristic, while ignoring unncessary details

## Advantages

- OOP is faster and easier to excute
- OOP provides a clear structure for the programs
- OOP help to keep C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify, and debug
- OOP makes it possible to create full reuable application with less code and shorter development time

## Resources

- https://dotnettutorials.net/lesson/object-oriented-programming-csharp/
- https://www.w3schools.com/cs/cs_oop.php
- Operator Overloading: https://www.tutorialspoint.com/csharp/csharp_operator_overloading.htm
- Polymorphism: https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
