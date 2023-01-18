Console.WriteLine("enter first number");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number");
int N2 = int.Parse(Console.ReadLine());
Console.WriteLine("enter third number");
int N3 = int.Parse(Console.ReadLine());

int max = N1;
if(N2>max) max=N2;
if(N3>max) max=N3;
Console.Write("the maximum is:");
Console.WriteLine(max);