void Zadacha41()
{
    //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("Задача 41.");
    Console.WriteLine("введите несколько чисел через пробел");
    string number = Console.ReadLine();
    string[] numberSplit = number.Split();
    double result = 0;
    for (int i = 0; i < numberSplit.Length; i++)
    {
        if (Convert.ToInt32(numberSplit[i]) > 0)
        result = result + 1;
    }
    Console.WriteLine($"Чисел больше нуля введено: {result}");

}
void Zadacha43()
{
    //Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    Console.WriteLine("Задача 43.");
    Console.WriteLine("Введите значение b1");
    double numberb1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1");
    double numberk1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double numberb2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double numberk2 = Convert.ToInt32(Console.ReadLine());
    double x = (numberb2 - numberb1)/(numberk1-numberk2);
    double y = numberk1 * x + numberb1;
    Console.WriteLine($"Прямые пересекаются в точке:  ({Math.Round(x,2)};{Math.Round(y,2)})");
}
//Zadacha41();
Zadacha43();