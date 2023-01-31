// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("enter array length");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("enter array left side(minimum for random");
int left = int.Parse(Console.ReadLine());
Console.WriteLine("enter array right side(maximum for random");
int right = int.Parse(Console.ReadLine());
int [] array7 = new int [l];

for ( int i=0; i< l; i++)
{
    array7[i] = new Random().Next(left,right);
}
Console.Write("our array is: ");
Console.WriteLine(string.Join (" *", array7 ));

int min = array7[0];
int max = array7[1];
for (int i= 0; i<l;i++)
{
    if (array7[i]>max)
    {
        max = array7[i];
    }
    if (array7[i]<min)
    {
        min = array7[i];
    }
}
int result = max - min;
Console.WriteLine("the difference between min value: " +  min + " and max value: " + max + " = " + result);
