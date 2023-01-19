Console.WriteLine("Enter any three-digit number");
int x = int.Parse(Console.ReadLine());
if((x>99)&(x<1000))
{
    int y = x % 10 ;
    Console.WriteLine ("the third digit is:  ");
    Console.WriteLine (y);
}
else
{
    Console.WriteLine("This number isn't requered condition");
}

