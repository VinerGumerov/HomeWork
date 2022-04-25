/*
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void cube (int N)
{
    int count = 1;
    Console.Write(N + "-> ");
    while (count <= N)
    {
        Console.Write(", " + count*count*count );
        count++;
    }
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
  cube(num);
else
  Console.Write("Please enter a positive number");    


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Sqrt (double x1,double x2,double y1,double y2,double z1, double z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}
Console.WriteLine("Input x1 cordinate: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2 cordinate: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1 cordinate: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2 cordinate: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1 cordinate: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2 cordinate: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Sqrt(x1,x2,y1,y2,z1,z2));

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Pal()
{
  Console.WriteLine("Enter a five-digit number: ");
  int num = Convert.ToInt32(Console.ReadLine());
  int n1 = num / 10000;
  int n2 = num / 1000 % 10;
  int n3 = num % 100 / 10;
  int n4 = num % 10;
  if(n1 == n4 && n2 == n3)
  Console.WriteLine(num + "-> Это палиндром!");
  else
  Console.WriteLine(num + "-> Это не палиндром!");
}
Pal();

*/