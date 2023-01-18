Console.WriteLine("enter first number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int y = int.Parse(Console.ReadLine());//Convert.ToInt32(Console.ReadLine())//mix of two is possible
int s1 = x * x;
int s2 = y * y;
if (s1 == y )
{
    Console.WriteLine("second is a square of first");
}
else
{
    if (s2 == x)
    {
        Console.WriteLine("first is a square of second");
    }
    else
    {
       Console.WriteLine("none of these");
    }
}