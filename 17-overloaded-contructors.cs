
Sum insta1 = new Sum(5, 10);
Sum insta2 = new Sum(3, 7, 2, 4);
Sum insta3 = new Sum(1, 2, 3, 4, 5);
Sum insta4 = new Sum(60);
Console.WriteLine($"The sum of 5 and 10 is: {insta1.result}");
Console.WriteLine($"The sum of 3, 7, 2 and 4 is: {insta2.result}");
Console.WriteLine($"The sum of 1, 2, 3, 4 and 5 is: {insta3.result}");
Console.WriteLine($"The sum of 60 is: {insta4.result}");

class Sum
{
    double a;
    double b;
    double c;
    double d;
    double e;
    public double result; // Add this public field

    public Sum(double a, double b)
    {
        this.a = a;
        this.b = b;
        result = a + b; // Remove 'return' keyword
    }

    public Sum(double a, double b, double c, double d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        result = a + b + c + d; // Remove 'return' keyword
    }

    public Sum(double a, double b, double c, double d, double e)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.e = e;
        result = a + b + c + d + e; // Remove 'return' keyword
    }

    public Sum(double a)
    {
        this.a = a;
        result = a; // Remove 'return' keyword
    }
}