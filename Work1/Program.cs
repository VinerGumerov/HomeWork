/*
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
 


Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 != 5 || num2 != 7)
   Console.WriteLine("Incorrect number ");

else
{
   Console.WriteLine("Result min number is " + num1);
   Console.WriteLine("Result max number is " + num2);
}



Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 != 2 || num2 != 10)
   Console.WriteLine("Incorrect number ");

else
{
   Console.WriteLine("Result min number is " + num1);
   Console.WriteLine("Result max number is " + num2);
}




Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 != -9 || num2 != -3)
   Console.WriteLine("Incorrect number ");

else
{
   Console.WriteLine("Result min number is " + num1);
   Console.WriteLine("Result max number is " + num2);
}
//

//
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22



Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2 && num1 > num3)
{
  Console.WriteLine("Result max number is " + num1 );
}
else
{
   if (num1 < num2 && num2 > num3)
   {
      Console.WriteLine("Result max number is " + num2 );
   }
   else
   {
      if (num1 < num3 && num2 < num3)
      {
         Console.WriteLine("Result max number is " + num3 );
      }
   }
}
//

//
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.Write("Input integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
   Console.WriteLine("number is even ");
}
else
{
   Console.WriteLine("number is not even ");
}
//

//
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8



Console.Write("Input integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
{
   if (i % 2 == 0)
   {
      Console.Write(i + " ");
   }
}
//
/*