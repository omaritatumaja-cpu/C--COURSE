using System;

namespace MyFirstProgram;

// Using a Primary Constructor to define the 'speed' property directly
class Car(int speed, string name)
{
    private int _speed = speed;
    public string name = name;
    public int Speed
    {
        get;
        set;
    }
}

class Program
{
    static void Main()
    {
        var car = new Car(400, "abu");
        car.Speed = 1000000000;
        Console.WriteLine(car.Speed); // Output: 500
        car.Speed = 300;
        Console.WriteLine(car.Speed);
        Console.WriteLine(car.name);
        // Console.WriteLine(car.speed); // output :error CS1061
    }
}