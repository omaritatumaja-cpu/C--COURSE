Console.WriteLine("Enter your of age");
string ageInput = Console.ReadLine();
double age= Convert.ToDouble(ageInput);
if (age >= 18)
{
    Console.WriteLine("You are now signed up for the service.");
}
else if (age < 0)
{
    Console.WriteLine("Invalid age. Please enter a valid age.");
}
else
{
    Console.WriteLine("you must be 18+ to sign up for the service.");
}


 