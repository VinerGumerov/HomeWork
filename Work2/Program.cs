 /*
 //Задача 1.
 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    int n1 = num / 10;
    int n2 = n1 % 10;
    Console.WriteLine(n2);
}
ReduceNumber();



//Задача 2. 
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input the number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
void Dayoff( int d)
{
    Console.Write(d + " -> ");
    if( d > 5 && d < 8)
    {
        Console.WriteLine("Weekend");
    }
    else
    {
         if(d < 1 || d > 7)
        Console.Write("Incorect number of day!!!");
        else
        Console.Write("Working day");
    }
   
        
}
Dayoff(day);



//Задача 3.
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int ThirdNum(int n)
{   
    Console.Write(n + " -> ");
    if(n < 100)
    {
        Console.WriteLine("Third digit doesn't exsist");
        return n;
    }
    if (n > 999)
    {
        int result1 = (n/10);
        int result2 = (result1%10);
        Console.WriteLine(result2);
        return result1;
    }
    else
    {
        int result = (n %10)  ;
        Console.WriteLine(result);
        return result;
    }
}
ThirdNum(num);
*/