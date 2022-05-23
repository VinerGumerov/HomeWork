//Задача 66: 
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNum(int M, int N)
{
    if (M < N)
    {
        M +=1;
        return M + SumNum(M,N);
    }
    else return 1;
}
Console.WriteLine(SumNum(1,15));
*/

//Задача 67: 
//Напишите программу, 
//которая будет принимать на вход число и возвращать сумму его цифр.

int NaturalNums(int n)
{
    if (n >= 1)
    {
        n -= 1;
        return (n+1) + NaturalNums(n);
    }
    else return 0;
}
Console.WriteLine(NaturalNums(9));


