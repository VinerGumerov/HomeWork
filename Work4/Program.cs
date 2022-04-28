/*
//Задача 38:
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateArray(int size)
{
    int[] array = new int[size];
    int max = 0; 
    int min=100;
    for (int i = 0; i<size; i++ )  
    array[i] = new Random().Next(100);
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(" "+array[i]);
        Console.WriteLine();
        Console.WriteLine("max:  " + max);
        Console.WriteLine("min  " +min);
        Console.WriteLine("Разница максимального и минимального:  "+(max - min));
        Console.ReadKey();
    }
}

//Задача 34:
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int count = 0;
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,999);
        if(array[i] % 2 == 0)
        {
            count ++;
            Console.WriteLine("Number of even elements: -> " + count);

        }
        else
        {
            Console.WriteLine("No even numbers");  
        }
    }
    return array;
}


//Задача 36:
//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
void FindSumofElements ( int [] array)
{
    int negative = 0;
    int positive = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if(array [i] / 2 == 0)
        negative = negative - array [i];
        else
        positive = positive + array [i];

    }
Console.WriteLine("sum vnflk" + negative);
Console.WriteLine("sum vnflk" + positive);
}
*/