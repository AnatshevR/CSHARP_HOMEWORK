Console.WriteLine("Enter any integer");
int x = int.Parse(Console.ReadLine());
int remainder = x % 1000;
int result = remainder /100;
if (x>99 || x<-99)
{
    Console.Write("the third digit from the end is: ");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("there is no third digit");
}