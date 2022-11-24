void Zadacha1()
{
    //Рассчитать значение y при заданном x по формуле: y = sin^2 x ghb x>0
    //в других случаях y = 1 -2sinx^2 
    Console.WriteLine("Задача 1.");
    Random rand = new Random();
    int number = rand.Next(-10, 10);
    Console.WriteLine("Введен x: " + number);
    double y = 0;
    if (number > 0)
    {
        y = Math.Round(Math.Sin(number) * Math.Sin(number), 2);
        Console.WriteLine("y равен: " + y);
    }
    else
    {
        y = Math.Round(1 - 2 * Math.Sin(number * number), 2);
        Console.WriteLine("y равен: " + y);
    }
}
void Zadacha2()
{//Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
    Console.WriteLine("Задача 2.");
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("Введено число: " + number);
    int result = 0;
    while (number > 0)
    {
        result = number % 10 + result;
        number = number / 10;
    }
    Console.WriteLine("Сумма цифр: " + result);
    if (result % 3 == 0) Console.WriteLine("Сумма цифр кратна 3");
    else Console.WriteLine("Сумма цифр не кратна 3");
}
void Zadacha3()
{
    // Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
    Console.WriteLine("Задача 3.");
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("Введено число: " + number);
    int hunds = number / 100;
    int tens = number / 10 % 10;
    int ones = number % 10;
    if (hunds == 4 || tens == 4 || ones == 4)
    {
        Console.WriteLine("Среди цифр числа есть 4");
    }
    if (hunds == 7 || tens == 7 || ones == 7)
    {
        Console.WriteLine("Среди цифр числа есть 7");
    }
    else Console.WriteLine("Среди цифр числа нет 4 или 7");
}
void Zadacha4()
{
    //Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
    Console.WriteLine("Задача 4.");
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    void PrintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    PrintArray(arr);
}
void Zadacha1Up()
{// На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
 //Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
    Console.WriteLine("Задача 1. Повышенной сложности");
    Console.WriteLine("Введите номер четверти");
    int number = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();
    if (number == 1)
    {
        int x1 = rand.Next(1, 11);
        int y1 = rand.Next(1, 11);
        int x2 = rand.Next(1, 11);
        int y2 = rand.Next(1, 11);
        int x3 = rand.Next(1, 11);
        int y3 = rand.Next(1, 11);
        Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}); C({x3}, {y3})");
        double resultfirst = Math.Sqrt(Math.Pow((0 - x1), 2) + Math.Pow((0 - y1), 2));
        double resultsecond = Math.Sqrt(Math.Pow((0 - x2), 2) + Math.Pow((0 - y2), 2));
        double resultthird = Math.Sqrt(Math.Pow((0 - x3), 2) + Math.Pow((0 - y3), 2));
        double min = resultfirst;
        if (min > resultsecond) min = resultsecond;
        if (resultsecond > resultthird) min = resultthird;
        Console.WriteLine("Самый короткий маршрут из центра координат до одной из точек равен: " + Math.Round(min, 2));
    }
    if (number == 2)
    {
        int x1 = rand.Next(-10, 0);
        int y1 = rand.Next(1, 11);
        int x2 = rand.Next(-10, 0);
        int y2 = rand.Next(1, 11);
        int x3 = rand.Next(-10, 0);
        int y3 = rand.Next(1, 11);
        Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}); C({x3}, {y3})");
        double resultfirst = Math.Sqrt(Math.Pow((0 - x1), 2) + Math.Pow((0 - y1), 2));
        double resultsecond = Math.Sqrt(Math.Pow((0 - x2), 2) + Math.Pow((0 - y2), 2));
        double resultthird = Math.Sqrt(Math.Pow((0 - x3), 2) + Math.Pow((0 - y3), 2));
        double min = resultfirst;
        if (min > resultsecond) min = resultsecond;
        if (resultsecond > resultthird) min = resultthird;
        Console.WriteLine("Самый короткий маршрут из центра координат до одной из точек равен: " + Math.Round(min, 2));
    }
    if (number == 3)
    {
        int x1 = rand.Next(-10, 0);
        int y1 = rand.Next(-10, 0);
        int x2 = rand.Next(-10, 0);
        int y2 = rand.Next(-10, 0);
        int x3 = rand.Next(-10, 0);
        int y3 = rand.Next(-10, 0);
        Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}); C({x3}, {y3})");
        double resultfirst = Math.Sqrt(Math.Pow((0 - x1), 2) + Math.Pow((0 - y1), 2));
        double resultsecond = Math.Sqrt(Math.Pow((0 - x2), 2) + Math.Pow((0 - y2), 2));
        double resultthird = Math.Sqrt(Math.Pow((0 - x3), 2) + Math.Pow((0 - y3), 2));
        double min = resultfirst;
        if (min > resultsecond) min = resultsecond;
        if (resultsecond > resultthird) min = resultthird;
        Console.WriteLine("Самый короткий маршрут из центра координат до одной из точек равен: " + Math.Round(min, 2));
    }
    if (number == 4)
    {
        int x1 = rand.Next(1, 11);
        int y1 = rand.Next(-10, 0);
        int x2 = rand.Next(1, 11);
        int y2 = rand.Next(-10, 0);
        int x3 = rand.Next(1, 11);
        int y3 = rand.Next(-10, 0);
        Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}); C({x3}, {y3})");
        double resultfirst = Math.Sqrt(Math.Pow((0 - x1), 2) + Math.Pow((0 - y1), 2));
        double resultsecond = Math.Sqrt(Math.Pow((0 - x2), 2) + Math.Pow((0 - y2), 2));
        double resultthird = Math.Sqrt(Math.Pow((0 - x3), 2) + Math.Pow((0 - y3), 2));
        double min = resultfirst;
        if (min > resultsecond) min = resultsecond;
        if (resultsecond > resultthird) min = resultthird;
        Console.WriteLine("Самый короткий маршрут из центра координат до одной из точек равен: " + Math.Round(min, 2));
    }
    else Console.WriteLine("Неверный ввод");
}
//Zadacha1();
//Zadacha2();
//Zadacha3();
//Zadacha4();
Zadacha1Up();