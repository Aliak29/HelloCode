void Zadacha25()
{
    //Используя определение степени числа, напишите цикл, который принимает на вход два
    //натуральных числа (A и B) и возводит число A в степень B.
    Console.WriteLine("Задача 25.");
    Random rand = new Random();
    int numberFirst = rand.Next(1, 10);
    Console.WriteLine("Введено число: " + numberFirst);
    int numberSecond = rand.Next(1, 10);
    Console.WriteLine("Введено число: " + numberSecond);
    Console.WriteLine("Ответ: " + Math.Pow(numberFirst, numberSecond));
}
void Zadacha27()
{//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.WriteLine("Задача 27.");
    Random rand = new Random();
    int number = rand.Next(1, 1000);
    Console.WriteLine("Введено число: " + number);
    int result = 0;
    while (number > 0)
    {
        result = number % 10 + result;
        number = number / 10;
    }
    Console.WriteLine("Ответ: " + result);
}
void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-100, 100);
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
            if (Math.Abs(nums[j]) < Math.Abs(nums[minPosition])) minPosition = j;
        }
        int temporary = nums[i];
        nums[i] = nums[minPosition];
        nums[minPosition] = temporary;
    }
}
void Zadacha29()

{
    //Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный
    //по модулю массив.
    Console.WriteLine("Задача 29.");
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    SelectionSort(numbers);
    PrintArray(numbers);
}
//Zadacha25();
//Zadacha27();
Zadacha29();