
Animal anima1 = new Animal("dog", 5, "brown");
Animal anima2 = new Animal("cat", 3, "white");
Animal anima3 = new Animal("rabbit", 2, "gray");

// add .ToString() method to the Animal class or remove .ToString() method calls gives the same output
Console.WriteLine(anima1.ToString());
Console.WriteLine(anima2);
Console.WriteLine(anima3.ToString());
class Animal
{
    public string name;
    public int age;
    public string color;

    // Add this constructor
    public Animal(string name, int age, string color)
    {
        this.name = name;
        this.age = age;
        this.color = color;
    }
    public override string ToString()
    {
        return $"The {color} {name} is {age} years old.";
    }
}