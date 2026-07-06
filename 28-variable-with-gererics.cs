string x = "abu";
int y = 0;
double z = 0.4;
bool t = false;

Find(x);
Find(y);
Find(z);
Find(t);
static void Find<thing>(thing variable)
{
    Console.WriteLine(variable);
}