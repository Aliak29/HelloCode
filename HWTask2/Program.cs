﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}