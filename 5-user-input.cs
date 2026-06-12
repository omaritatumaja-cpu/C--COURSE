Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");

Console.WriteLine("Enter your age:");
string ageInput = Console.ReadLine();   
int age = Convert.ToInt32(ageInput);
Console.WriteLine($"You are {age} years old.");

Console.WriteLine("Enter a value of x");
string xInput = Console.ReadLine();
double x = Convert.ToDouble(xInput);
Console.WriteLine("Enter a value of y");
string yInput = Console.ReadLine();
double y = Convert.ToDouble(yInput);
double sum = x + y;
multiply = x * y;
Console.WriteLine($"The sum of {x} and {y} is {sum}");
Console.WriteLine($"The product of {x} and {y} is {multiply}");