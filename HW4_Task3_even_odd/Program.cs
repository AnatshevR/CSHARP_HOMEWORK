// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("enter the amount of elemets in array");
int L = int.Parse(Console.ReadLine());
int [] array = new int[L];
for (int i=0; i<L; i++)
{
    array[i] = new Random ().Next(100,1000);
}
Console.WriteLine(string.Join("*", array ));
int index = 0;
int even = 0;
int odd = 0;
while (index < L)
{
    if (array[index]%2==0)
    {
        even=even +1;
    }
    else
    {
        odd=odd +1;
    }
    index++;
}
Console.WriteLine("the amount of even numbers are: " + even);
Console.WriteLine("the amount of odd numbers are: " + odd);
