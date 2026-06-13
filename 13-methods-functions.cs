static void Greet(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}
Greet("Alice");
Greet("Bob");
Greet("Abdoul");
static int Add(int a, int b)
{
    Console.WriteLine("Adding " + a + " and " + b);
    return a + b;
    
}
int result = Add(5, 10);
Console.WriteLine("Result: " + result);

static void PrintMessage()
{
    Console.WriteLine("This is a message from the PrintMessage function.");
}
PrintMessage();
PrintMessage();
PrintMessage();