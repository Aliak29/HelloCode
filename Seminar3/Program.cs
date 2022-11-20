void Zadacha17()
{
    //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
    //в которой находится эта точка.
    Console.WriteLine("Задача 17.");
    Random rand = new Random(); // тип_данных имя_переменной = new тип_данных ();
    int x = rand.Next(-10, 11);
    int y = rand.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1-ая четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2-ая четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3-ая четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4-ая четверть");
    }
    else
    {
        Console.WriteLine("Точка лежит на координатной прямой");
    }
}
void Zadacha18()
{//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
    Console.WriteLine("Задача 18.");
    Console.WriteLine("Введите номер четверти");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 1)
    {
        Console.WriteLine("Диапозон возможных координат точек в 1-ой четверти (x,y)");
    }
    else if (number == 2)
    {
        Console.WriteLine("Диапозон возможных координат точек в 2-ой четверти (-x,y)");
    }
    else if (number == 3)
    {
        Console.WriteLine("Диапозон возможных координат точек в 3-ой четверти (-x,-y)");
    }
    else if (number == 4)
    {
        Console.WriteLine("Диапозон возможных координат точек в 4-ой четверти (x,-y)");
    }
    else
    {
        Console.WriteLine("введите цифру от 1 до 4");
    }
}
void Zadacha21()
{// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
    Console.WriteLine("Задача 21.");
    Console.WriteLine("Введите координату х1");
    int numberX1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y1");
    int numberY1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х2");
    int numberX2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y2");
    int numberY2 = Convert.ToInt32(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow((numberX2 - numberX1), 2) + Math.Pow((numberY2 - numberY1), 2));
    Console.WriteLine("Расстояние между точками равно: " + Math.Round (result, 2));
//Math.Round (Math.Sqrt(Math.Pow((numberX2 - numberX1), 2) + Math.Pow((numberY2 - numberY1), 2)), 2));
//Math.Round(x,3); - округление до кол-ва цифр, указанных в скобках
// Math/Pow(x, 2); - возвежение в степень, указанную после запятой
// Math.Sqrt(x); - корень квадратный от x

}
void Zadacha23()
{
// если необходимо сразу ввести 2 числа, решение через массив
Console.WriteLine("введите координаты числа А через пробел");
string pointA = Console.ReadLine();
Console.WriteLine("введите координаты числа B через пробел");
string pointB = Console.ReadLine();
string[] pointASplit= pointA.Split();
string[] pointBSplit= pointB.Split();
double distance = Math.Sqrt(Math.Pow(Convert.ToInt32(pointASplit[0]) - Convert.ToInt32(pointBSplit[0]), 2) + 
Math.Pow( Convert.ToInt32(pointASplit[1]) - Convert.ToInt32(pointBSplit[1]), 2));
Console.WriteLine(distance);
}
void Zadacha22()
{//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    Console.WriteLine("Задача 22.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int index = 1;
    while (index <= number)
    {
    Console.WriteLine($"{Math.Pow(index, 2)} ");
    index++;
    }
}
//Zadacha17();
//Zadacha18();
//Zadacha21();
//Zadacha22();
//Zadacha23();