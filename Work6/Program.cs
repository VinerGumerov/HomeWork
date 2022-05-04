/*
//Задача 41:
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Enter numbers through whitespace: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Числа > 0: {count}");


//Задача 42:
//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.

string DecimalNumbers(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result += Convert.ToString((num % 2));
        num /= 2;
    }
    result = new string (result.Reverse().ToArray());
    return  result;
}
Console.Write("Input number to convert in DecimalNumbers: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"In binary system = {DecimalNumbers(num2)}");

*/