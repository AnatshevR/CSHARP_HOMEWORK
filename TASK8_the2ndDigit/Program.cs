Console.WriteLine("Enter any three-digit number");
int x = int.Parse(Console.ReadLine());
if((x>99)&(x<1000))
{
    int y = x % 100 ;
    int w = y / 10;
    Console.WriteLine ("the second digit is:  ");
    Console.WriteLine (w);
}
else
{
    Console.WriteLine("This number isn't requered condition");
}
