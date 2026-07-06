using System;

namespace MyFirstProgram;

// Using a Primary Constructor to define the 'speed' property directly
class Car(int speed)
{
    private int _speed = speed;

    public int Speed
    {
        get => _speed; // Expression-bodied getter
        set => _speed = value > 500 ? 500 : value; // Expression-bodied setter with ternary logic
    }
}

class Program
{
    static void Main()
    {
        var car = new Car(400);
        car.Speed = 1000000000;
        Console.WriteLine(car.Speed); // Output: 500
    }
}