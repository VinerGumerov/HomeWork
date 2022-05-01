/*
//Задача 1:
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.


Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("num1^num2= " + Math.Pow(num1,num2));


//Задача 2: 
//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.


Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (num / 10 != 0)
{
    result += num % 10;
    num /= 10;
}
result += num;
Console.WriteLine(result);


//Задача 3: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = new int[8];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 150);
}
for (int j = 0; j < array.Length - 1; j++)
{
    Console.Write(array[j] + ", ");
}
Console.WriteLine(array[7] + "]");
*/

