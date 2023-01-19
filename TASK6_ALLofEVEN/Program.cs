Console.WriteLine("N= ");
int N = Convert.ToInt32(Console.ReadLine()!);
int i = 1;
while(i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write("Even numbers are: ");
        Console.WriteLine(  i);
        i++;
    }
    else
    {
        i++;
    }
            
}