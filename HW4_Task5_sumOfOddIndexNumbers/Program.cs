// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array5 = new int [8];
int i =0;
int L = array5.Length;
while ( i< L)
{
    array5[i] = new Random().Next(0,10);
    i++;
}
int sum =0;
for (int ind= 0;ind<L;ind++)
{
    if (ind%2==1)
    {
        sum = sum +array5[ind];
    }
}
Console.WriteLine(string.Join ("*", array5 ));
Console.WriteLine ("the sum of all numbers in odd index = " + sum);
