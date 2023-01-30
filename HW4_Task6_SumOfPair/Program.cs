// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("enter array length");
int l = int.Parse(Console.ReadLine());
int [] array6 = new int [l];
int i =0;
while ( i< l)
{
    array6[i] = new Random().Next(0,10);
    i++;
}
int product =0;
Console.WriteLine(string.Join ("*", array6 ));
Console.WriteLine("the product of pair numbers in array6 are: ");
for (int ind= 0;ind<l/2;ind++)
{
    product = array6[ind] * array6[(l-1)-ind];
    Console.WriteLine (array6[ind] + " * " + array6[(l-1)-ind] + " = " + product);
}


