﻿Console.WriteLine("enter coordinate x for first point");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("enter coordinate y for first point");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("enter coordinate z for first point");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("enter coordinate x for second point");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("enter coordinate y for second point");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("enter coordinate z for second point");
double z2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine("the distanse between first and second point is: ");
Console.WriteLine(result);