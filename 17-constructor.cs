// 1. Executable code goes at the top
var inst1 = new Salituation("Abu", 25, false);
inst1.hello();
Console.WriteLine($"My name is {inst1.name} and I am {inst1.age} years old. and heis he married? {inst1.isMarried}");

// 2. Class definitions must go at the bottom
class Salituation
{//defining a constructor
    public Salituation(string name, int age, bool isMarried)
    {
        this.name = name;
        this.age = age;
        this.isMarried = isMarried;
    }
    public string name;
    public int age;
    public bool isMarried = false;
    // Added 'public' so it can be accessed outside the class
    public void hello()
    {
        Console.WriteLine("hello, Abu");
    }
}