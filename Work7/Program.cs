//Задача 47.
//Задайте двумерный массив размером m×n.
//Заполненный случайными вещественными числами.

/*
Console.Write("Input size matrix(vertical): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size matrix(horizontal): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}


//Задача 50.
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве. 
//И возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
if (num1 < 0 || num1 >= 3 && num2<0 || num2 >= 4)
    Console.WriteLine("The number does not belong to the array");
else
    Console.WriteLine($"belongs to the array: {matrix[num1,num2]} ");

*/

