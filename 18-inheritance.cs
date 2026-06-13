using System;

// 1. Executable code
var animal = new Animal(5);
var dog = new Dog(3); // Pass the age directly to the constructor

dog.eat("dog food");
dog.isMammal = true;
Console.WriteLine($"The dog is {dog.age} years old and is a mammal: {dog.isMammal}");

// 2. Class definitions
class Animal
{
    public int age; // Added the missing field declaration for age
    public bool isMammal;

    public Animal(int age)
    {
        this.age = age;
    }

    public void eat(string food = "food")
    {
        Console.WriteLine($"The animal is eating {food}.");
    }
}

class Dog : Animal
{
    // The Dog constructor takes the age and passes it down to the Animal constructor
    public Dog(int age) : base(age)
    {
    }

    public void bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}