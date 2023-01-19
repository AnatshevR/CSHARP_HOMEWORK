Console.WriteLine("enter first positive integer");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("enter any divider");
int divider = int.Parse(Console.ReadLine());
int result = number / divider;
int remainder = number % divider;
if(number%divider==0)
{
    Console.WriteLine("your number is multiple");
    Console.Write("Result is: ");
    Console.WriteLine(result);
}
else
{
    Console.Write("you have remainder: ");
    Console.WriteLine(remainder);
}
