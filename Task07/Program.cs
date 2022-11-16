// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000)
{
    number = Math.Abs(number);
    number = number % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Ошибочное значение");
}
