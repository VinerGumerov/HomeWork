//Задача 56 
//Задайте прямоугольный двумерный массив. 
//Напишите программу,которая будет находить строку с наименьшей суммой элементов.
/*

int[,] matrix = new int[3,6];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 6; j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j]+ "\t ");
    }
    Console.WriteLine();
}

int RowNumber(int[,] matrix)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            sum += matrix[i,j];
        }
        if (i==0) result = sum;
        else
        {
            result = sum;
            index = i;
        }
    }
    Console.Write(matrix[3,6] + index);
    return index;
}
RowNumber(matrix);
*/


//Задача 54: 
//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] CreateArray(int rowsAmt, int colsAmt, int minVal, int maxVal)
{
    int[,] array = new int[rowsAmt, colsAmt];
    for (int i = 0; i < rowsAmt; i++)
    {
        for (int j = 0; j < colsAmt; j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    PrintArray(array);
    Console.WriteLine();
    return array;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[] ArrayParametersInput()
{
    int rows = 0, cols = 0;

    while (true)
    {
        Console.Write("Введите количество строк (начиная с 1): ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов (начиная с 1): ");
        cols = Convert.ToInt32(Console.ReadLine());
        if (rows > 0 && cols > 0)
            break;
        else
            Console.WriteLine("Количество и строк и столбцов должно быть больше 0. Пожалуйста повторите попытку.");
    }

    Console.Write("Введите нижнюю границу диапазона значений: ");
    int lowerValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхнюю границу диапазона значений: ");
    int upperValue = Convert.ToInt32(Console.ReadLine());

    int[] paramsOut = { rows, cols, lowerValue, upperValue };
    return paramsOut;

}

int[,] SortArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPos = j;
            for(int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if(matrix[i, k] < matrix[i, minPos])
                {
                    minPos = k;
                }
            }
            
            (matrix[i, minPos], matrix[i, j]) = (matrix[i, j], matrix[i, minPos]);  
        }
    }
    return matrix;
}
int[] arrayParameters = ArrayParametersInput();
PrintArray(SortArray(CreateArray(arrayParameters[0],    
                                 arrayParameters[1],    
                                 arrayParameters[2],    
                                 arrayParameters[3]    
                                 )));