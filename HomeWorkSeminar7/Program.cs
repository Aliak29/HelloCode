void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FillDoubleArray(double[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
        }
    }
}
void PrintDoubleArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
string Input(string inputText)
{
    Console.WriteLine(inputText);
    return Console.ReadLine();
}
void Zadacha47()
{
    //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
    Console.WriteLine("Задача 47.");
    int rows = 3;
    int columns = 4;
    double[,] numbers = new double[rows, columns];
    FillDoubleArray(numbers);
    PrintDoubleArray(numbers);
}
void Zadacha50()
{
    //Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента
    // или же указание, что такого элемента нет.
    Console.WriteLine("Задача 50.");
    int rows = 3;
    int columns = 3;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    int indexi = Convert.ToInt32(Input("Введите индекс i"));
    int indexj = Convert.ToInt32(Input("Введите индекс j"));
    if (indexi < 0 || indexj < 0 || indexi > rows - 1 || indexj > columns - 1) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine($"Введеному индексу соответствует элемент=> {numbers[indexi, indexj]}");
}
void Zadacha52()
{
    //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Console.WriteLine("Задача 52.");
    int rows = 5;
    int columns = 3;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    double sum = 0;
    double average = 0;
    for (int j = 0; j <columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            {
                sum += numbers[i, j];
            }
        }
        average = Math.Round(sum / rows, 1);
        Console.WriteLine($"Среднее арифметическое элементов в столбце: {average}");
        sum = 0;
    }
}
//Zadacha47();
//Zadacha50();
Zadacha52();