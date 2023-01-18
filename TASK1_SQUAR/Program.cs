Console.WriteLine("enter any integer");
int x = Convert.ToInt32(Console.ReadLine());
int quad = x*x;
Console.Write("quad of entered integer =  ");
Console.WriteLine(quad);
//программа работает но только с целыми числами
//варианты модернизации : 1) сделать универсальную для дробных и целых
//                        2) задать рандомное число