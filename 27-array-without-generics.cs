
// generic =  "not specific to a particular data type"
//            add <T> to: classes, methods, fields, etc.
//            allows for code reusability for different data types

int[] intArray = { 1, 2, 3 };
double[] doubleArray = { 1.0, 2.0, 3.0 };
String[] stringArray = { "1", "2", "3" };

displayElements1(intArray);
displayElements2(doubleArray);
displayElements3(stringArray);

Console.ReadKey();

static void displayElements1(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

static void displayElements2(double[] array)
{
    foreach (double item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
static void displayElements3(string[] array)
{
    foreach (string item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
