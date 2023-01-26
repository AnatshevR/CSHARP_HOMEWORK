Console.WriteLine("enter any integer");
int N = int.Parse(Console.ReadLine());
if (N>1)
{
    for (int i = 2; i<=N ; i++)
    {
        if (i%2==0)
        {
            int cube = Convert.ToInt32(Math.Pow(i,3));
            Console.WriteLine("The cube of " + i + " = " + cube);
        }
    }
}
else if (N<-1)
{
    N = N * -1;
        for (int i = 2; i<=N ; i++)
    {
        if (i%2==0)
        {
            int cube = -1 * Convert.ToInt32(Math.Pow(i,3));
            Console.WriteLine("The cube of " + " - " + i + " = " + cube);
        }
    }
}
else 
{
    Console.WriteLine("the number must be >1 or <-1");
}