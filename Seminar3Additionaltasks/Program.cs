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
    if (hunds % 4 == 0 || hunds % 7 == 0)
    {
        Console.WriteLine("Первая цифра числа кратна 4 или 7 " + hunds);
    }
    if (tens % 4 == 0 || tens % 7 == 0)
    {
        Console.WriteLine("Вторая цифра числа кратна 4 или 7 " + tens);
    }
    if (ones % 4 == 0 || ones % 7 == 0)
    {
        Console.WriteLine("Третья цифра числа кратна 4 или 7 " + ones);
    }
    else Console.WriteLine("Ни одна цифра числа не кратна 7 или 4");
}
void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(1, 11);
    }
}
void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write((nums[i]) + " ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] nums)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] < nums[minPosition]) minPosition = j;
        }
        int temporary = nums[i];
        nums[i] = nums[minPosition];
        nums[minPosition] = temporary;
    }
}
void Zadacha4()
{
    //Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
    Console.WriteLine("Задача 4.");
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    SelectionSort(numbers);
    PrintArray(numbers);
}
//Zadacha1();
//Zadacha2();
//Zadacha3();
Zadacha4();