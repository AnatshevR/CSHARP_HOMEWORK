// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int [] myarray = new int [8];
int i =0;
int L = myarray.Length;
while ( i< L)
{
    myarray[i] = new Random().Next(0,2);
    i++;
}
Console.WriteLine(string.Join ("*", myarray ));
