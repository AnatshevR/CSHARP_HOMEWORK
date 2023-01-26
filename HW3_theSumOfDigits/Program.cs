Console.WriteLine("Enter any integer to sum all digits");
int N = int.Parse(Console.ReadLine());
int sum = 0;
if (N>0)
{
    while(N>9)
    {
        sum = sum + N % 10;
        N = N/10;
    }
    sum = sum + N%10;
    Console.WriteLine("the sum of all digits in your number is: " + sum);
}
else
{
    while (N< -9)
    {
        sum = sum +N % 10;
        N = N / 10;
    }
    sum = (sum + N % 10);
    // sum = (sum + N % 10) * -1;  // if you want to have positive sum in case of negative number
    Console.WriteLine("the sum of all digits in your number is: " + sum);
}
