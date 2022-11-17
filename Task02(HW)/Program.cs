// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее. 
// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("Максимальное число равно: ");
    Console.Write($"{b} ");
}
else if(a>b)
{
    Console.WriteLine("Максимальное число равно: ");
    Console.Write($"{a} ");
}
else if(a==b)
{
    Console.WriteLine("Числа равны");
}
