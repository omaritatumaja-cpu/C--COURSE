Animal[] animals = new Animal[3];

Animal anima1 = new Animal("dog", 5, "brown");
Animal anima2 = new Animal("cat", 3, "white");
Animal anima3 = new Animal("rabbit", 2, "gray");
call(anima1, "black", 6, "dog");


static void call(Animal animal1, string color, int age, string name)
{
    animal1.color = color;
    animal1.age = age;
    animal1.name = name;

    Console.WriteLine($"The {animal1.color} {animal1.name} is {animal1.age} years old.");
}

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