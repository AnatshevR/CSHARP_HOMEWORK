Console.WriteLine("To see a possible coordinates please choose the quarter (it must be from 1 to 4)");
int coord = int.Parse(Console.ReadLine());
if (coord == 1)
{
    Console.WriteLine("for this quarter coordinates will be:");
    Console.WriteLine(" x>0 y>0");
}
else if ( coord == 2)
{
    Console.WriteLine("for this quarter coordinates will be:");
    Console.WriteLine(" x<0 y>0");
}
else if ( coord == 3)
{
    Console.WriteLine("for this quarter coordinates will be:");
    Console.WriteLine(" x<0 y<0");
}
else if ( coord == 4)
{
    Console.WriteLine("for this quarter coordinates will be:");
    Console.WriteLine(" x>0 y<0");
}
else 
{
    Console.WriteLine("this number is out of quarter");
}