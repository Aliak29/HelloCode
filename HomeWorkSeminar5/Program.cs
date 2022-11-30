void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}
void Zadacha34()
{//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
 //количество чётных чисел в массиве.
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Количество четных элементов массива: " + count);
}
void Zadacha36()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int sum = 0;
    for (int i = 1; i < size; i++)
    {
        sum += numbers[i];
        i++;
    }
    Console.WriteLine("Сумма элементов с нечётными индексами равна: " + sum);
}
void FillArrayDouble(double[] nums)
{
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
}
void PrintArrayDouble(double[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}
void Zadacha38()
{
    //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    int size = 5;
    double[] numbers = new double[size];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    double min = numbers[0];
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    Console.WriteLine("Минимальное число: " + min);
    double max = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    Console.WriteLine("Максимальное число: " + max);
    double result = max - min;
    Console.WriteLine("Разница чисел: " + result);
}
//Zadacha34();
//Zadacha36();
//Zadacha38();