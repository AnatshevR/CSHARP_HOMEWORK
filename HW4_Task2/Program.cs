// Определить, присутствует ли в заданном массиве, некоторое число

int [] array = new int[20];
int L = array.Length;
for (int i=0; i<L; i++)
{
    array[i] = new Random ().Next(1,21);
}
Console.WriteLine(string.Join("*", array ));
Console.WriteLine("enter integer from 1 to 20 to check position");
int X = int.Parse(Console.ReadLine());
int index = 0;
if (X>0 && X<21)
{
    while (index < L)
    {
        if ( array[index] == X ) 
        {
            Console.WriteLine("your number has next index position: " + index);
        }
        index++;
    }
    Console.WriteLine("             *If you dont see any index position there is no coincedence");
}
else
{
    Console.WriteLine("your number is out of range, please enter correct number");
}

