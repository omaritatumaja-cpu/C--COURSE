Random random=new Random();
int randomNumber=random.Next(1, 100);   
double randomDouble=random.NextDouble() * 4 + 1; // Generates a random double between 1 and 5
Console.WriteLine($"the random number is {randomNumber}");
Console.WriteLine($"the random double is {randomDouble}");