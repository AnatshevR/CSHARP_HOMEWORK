Console.WriteLine("enter integer number for cube calculation");
int N = int.Parse(Console.ReadLine());
for (int i=1; i<=N; i++)
{
    double stepen = 3;
    double cube = Math.Pow(i,stepen);// without convert but we should use double
    //int cube = Convert.ToInt32(Math.Pow(i,3));//with using of Convert 
    Console.WriteLine("the cube of number " + i + " is equal " + cube);    //short form 

    //Console.Write(i);                                                      long form
    //Console.Write(" is equal ");
    //Console.WriteLine(cube);
}
//Convert.ToInt32(Math.Pow(5, 3))