// Напишите программу, которая 
// 1. принимает на
// вход три числа и 
// 2. выдаёт максимальное из этих чисел. 
// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа: ");
int num1;
int num2;
int num3;
int max;

num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    max = num1;
    if (num1 > num3)
    {
        Console.WriteLine("Максимальное число равно: ");
        Console.Write($"{max}");
    }
}
if (num2 > num3)
{
    max = num2;
    if (num2 > num1)
    {
        Console.WriteLine("Максимальное число равно: ");
        Console.Write($"{max}");
    }
}
if (num3 > num1)
{
    max = num3;
    if (num3 > num2)
    {

        Console.WriteLine("Максимальное число равно: ");
        Console.Write($"{max}");
    }
}


