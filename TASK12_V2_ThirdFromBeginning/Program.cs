Console.WriteLine("Enter any integer");
int x = int.Parse(Console.ReadLine());
while (x <-999 || x >999)
{
    x = x / 10;
}
if (x>99 || x<-99)
{
    int result = x % 10;
    Console.Write("the third digit from the beginning is: ");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("there is no third digit");
}
