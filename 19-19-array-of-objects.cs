
Animal anima1 = new Animal("dog", 5, "brown");
Animal anima2 = new Animal("cat", 3, "white");
Animal anima3 = new Animal("rabbit", 2, "gray");
Animal[] animals = { anima1, anima2, anima3 };

Console.WriteLine($"The first animal is a {animals[0].color} {animals[0].name} that is {animals[0].age} years old.");
Console.WriteLine($"The second animal is a {animals[1].color} {animals[1].name} that is {animals[1].age} years old.");
Console.WriteLine($"The third animal is a {animals[2].color} {animals[2].name} that is {animals[2].age} years old.");

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
}