/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberThird = Convert.ToInt32(Console.ReadLine());

int m = numberFirst;
if (numberSecond > m) m = numberSecond;
else if (numberThird > m) m = numberThird;

Console.WriteLine(m);
