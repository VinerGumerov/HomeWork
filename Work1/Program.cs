﻿/*
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/ 


Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
   Console.WriteLine("Result min number is " + num1);
   Console.WriteLine("Result max number is " + num2);
}
else (num1! = 5 || num2! = 7)
{
   Console.WriteLine("Incorrect number ");
}   
