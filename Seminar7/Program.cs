void Zadacha46()
{
    //Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, -100, 100);
    PrintArray(numbers);
}
void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        //i=0
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
            //Console.WriteLine($"[A{i},{j}] = {numbers[i, j]}");
        }
    }
}
void CustomFillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        //i=0
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
            //Console.WriteLine($"[A{i},{j}] = {numbers[i, j]}");
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
void Zadacha48()
{
    //Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
    //Выведите полученный массив на экран.
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }
    }
    PrintArray(numbers);
}
void Zadacha49()
{
    //Задайте двумерный массив. Найдите элементы, у
    //которых оба индекса чётные, и замените эти элементы на их квадраты.
    int rows = 7;
    int columns = 7;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 4, 9);
    PrintArray(numbers);
    PowerForEvenIndex(numbers);
    Console.WriteLine();
    PrintArray(numbers);
}
void PowerForEvenIndex(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
}
void Zadacha51()
{
    //Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
    //(0,0); (1;1) и т.д.
    int rows = 5;
    int columns = 3;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 6);
    PrintArray(numbers);
    int min = Math.Min(rows, columns);
    int sum = 0;
    for (int i = 0; i < min; i++)
    {
        sum += numbers[i, i];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов по диагонале = " + sum);
}
string Input(string inputText)
{
    Console.WriteLine(inputText);
    return Console.ReadLine();
}
int count = Convert.ToInt32(Input("Введите число"));

//Zadacha46();
//Zadacha48();
//Zadacha49();
Zadacha51();