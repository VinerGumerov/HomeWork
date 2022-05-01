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


void SumOfElments(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        count+=array[i];
    }
    Console.WriteLine("SumOflements: "+count);
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
SumOfElments(num);


//Задача 3: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,8);
    }
    return array;
}
CreateRandomArray(size);
/*