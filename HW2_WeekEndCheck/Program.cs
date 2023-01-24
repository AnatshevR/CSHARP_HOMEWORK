Console.WriteLine("enter any number according day of a week");
int day = int.Parse(Console.ReadLine());
if (day>5 && day <8)
{
    Console.WriteLine("Congratulations: this is weekend!");
}
else
{
    if (day<1 || day >7)
    {
        Console.WriteLine("Please try again, the number must be from 1 to 7");
    }
    else
    {
        Console.WriteLine("Work hard! This is weekday!");
    }
}
