﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int a = 5;
int b = 7;

if (a > b)
{  
Console.Write("max=");
Console.Write(a);
Console.Write("min=");
Console.Write(b);
}
else
{
    Console.Write("max=");
    Console.Write(b);
    Console.Write("min=");
    Console.Write(a);
}