// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// Задача выполнена с условием что 10 и 99 входят в условие поиска
int [] array = new int [123];
int L = array.Length;
for (int i=0; i<L; i++)
{
    array[i]= new Random ().Next(1,124);
}
Console.WriteLine(String.Join("*", array));
int index = 0;
int count = 0;
while (index <L )
{
    if (array[index]>9 && array[index]<100)
    {
        count=count +1;
    }
    index++;
}
Console.WriteLine("there are " + count + " elements between 10 and 99 in this array");