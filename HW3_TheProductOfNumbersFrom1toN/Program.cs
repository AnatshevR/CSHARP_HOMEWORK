Console.WriteLine("enter any integer number to count a product");
int N = int.Parse(Console.ReadLine());
int sum = 1;
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        sum = sum * i;
    }
    Console.WriteLine("the product of all digits from 1 to " + N + " = " + sum);
}
else
{
    Console.WriteLine("your number is too small and result will be 0");
}
