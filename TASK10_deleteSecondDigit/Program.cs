int number = new Random ().Next (100,1000);
Console.Write("we have number:  ");
Console.WriteLine(number);
int x = number / 100;
int y = number % 10;
int result = x * 10 + y;
Console.Write("if we delete the center digit, the result will be: ");
Console.WriteLine(result);