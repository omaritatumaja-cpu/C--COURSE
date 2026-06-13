Console.WriteaLine("Enter a number to divide:");
string input = Console.ReadLine();      
try
{
    double number = Convert.ToDouble(input);
    double result = 100 / number;
    Console.WriteLine($"Result: {result}");
}
catch (FormatException e)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
}
finally
{
    Console.WriteLine("Operation completed.");
}