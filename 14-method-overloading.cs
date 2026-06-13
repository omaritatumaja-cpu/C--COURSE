static double CalculateArea(double radius)
{
    return Math.PI * radius * radius;
}
static double CalculateArea(double length, double width)
{
    return length * width;
}   
Console.WriteLine(CalculateArea(5.0)); // Output: 78.53981633974483
Console.WriteLine(CalculateArea(4.0, 6.0)); // Output: 24.0