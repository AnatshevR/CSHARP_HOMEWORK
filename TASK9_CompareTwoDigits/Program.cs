int numberA = new Random ().Next(10,100);
Console.Write("we have number:  ");
Console.WriteLine(numberA);
int x = numberA / 10;
int y = numberA % 10;
if (x>y)
{
    Console.Write("the bigger digit is:  ");
    Console.WriteLine(x);
}
else
{
    Console.Write("the bigger digit is: ");
    Console.WriteLine(y);
}