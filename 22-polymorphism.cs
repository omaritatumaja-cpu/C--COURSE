Human human1 = new Human();
Student student1 = new Student();
Male male1 = new Male();
Human[] array = { human1, student1, male1 };

class Human
{
    public Human()
    {
        Console.WriteLine("I am a human");
    }
}
class Male : Human
{
    public Male()
    {
        Console.WriteLine("I am a male");

    }
}
class Student : Human
{
    public Student()
    {
        Console.WriteLine("I am a student");
    }
}