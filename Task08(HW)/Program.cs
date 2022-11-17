// Напишите программу, которая 
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count < n)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
    count += 1;
    }
    else
    {
        Console.Write(" ");
        count += 1;
    }
}
