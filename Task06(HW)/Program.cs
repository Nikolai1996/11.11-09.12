// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Впишите число, чтобы узнать, является ли оно четным: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
   
     Console.WriteLine("Число четное");
}

else
{
    Console.WriteLine("Число нечетное");
}
