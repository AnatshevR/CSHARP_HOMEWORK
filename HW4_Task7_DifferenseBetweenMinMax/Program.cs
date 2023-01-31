// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("enter array length");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("enter array left side(minimum for random");
int left = int.Parse(Console.ReadLine());
Console.WriteLine("enter array right side(maximum for random");
int right = int.Parse(Console.ReadLine());
double [] array7 = new double [l];
Random rnd = new Random();

for ( int i=0; i< l; i++)
{
    array7[i] = rnd.Next(left,right)/100.00;  
}
Console.Write("our array is: ");
Console.WriteLine(string.Join (" *", array7 ));

double min = array7[0];
double max = array7[1];
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
double result = max - min;
Console.WriteLine("the difference between min value: " +  min + " and max value: " + max + " = " + result);
