static double Checkout(params double[] prices)
{
    double total = 0;
    foreach (double price in prices)
    {
        total += price;
    }
    return total;
}
Console.WriteLine(Checkout(10.5, 20.75, 15.0)); // Output: 46.25
Console.WriteLine(Checkout(5.99, 12.49)); // Output: 18.48