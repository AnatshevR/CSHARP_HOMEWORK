Console.WriteLine("enter any integer number");
int x = int.Parse(Console.ReadLine());

if (x%2==0)
{
    Console.Write(x);
    Console.WriteLine(" - is the even number");
}
else
{
    Console.Write(x);
    Console.WriteLine(" - is the odd number");
}