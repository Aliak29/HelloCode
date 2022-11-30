void Zadacha31()
{
    // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
    // отрицательных и положительных элементов массива.Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
    // чисел равна 29, сумма отрицательных равна -20

    int size = 12;
    //string[]
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    FindSumPos(numbers);
    FindSumNeg(numbers);
}
void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++; //увелечение максимального числа на единичку, чтобы включалось последнее число
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
void FindSumPos(int[] nums)
{
    int length = nums.Length;
    int sumPos = 0;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] > 0)
        {
            sumPos += nums[i];
        }
    }
    Console.WriteLine("Сумма положительных элементов равна: " + sumPos);
}
void FindSumNeg(int[] nums)
{
    int length = nums.Length;
    int sumNeg = 0;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] < 0)
        {
            sumNeg += nums[i];
        }
    }
    Console.WriteLine("Сумма отрицательных элементов равна: " + sumNeg);
}
void Zadacha32()
{//Напишите программу замены элементов массива: положительные элементы замените на
 //соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]
    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * -1;
    }
    PrintArray(numbers);
}
void Zadacha33()
/*
nt FindValue(int[] array, int value)
{
int result = -1, size = array.Length;
for (int i = 0; i < size; i++)
{
if (array[i] == value)
{
result = i;
i = size;
}
}
result++;
return result;
}
void Zadacha33()
{
int size = 12;
int[] array = new int[size];

FillRandomArray(array, -9, 9);
WriteArray(array);
Console.WriteLine("Введите нужное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int position = FindValue(array, value);
if (position == -1) Console.WriteLine("Данного числа в массиве нет");
else Console.WriteLine($"Первая позиция введенного числа {position}");
}
*/
{//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
 //4; массив [6, 7, 19, 345, 3] -> нет
 //3; массив [6, 7, 19, 345, 3] -> да
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 100);
    PrintArray(numbers);
    Console.WriteLine("Введите число от 0 до 100");
    int number = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    for (int i = 0; i < size && !flag; i++)
    {
        flag = numbers[i] == number;
    }
    if (flag) Console.WriteLine("Число есть в массиве");
    else Console.WriteLine("Числа нет в массиве");
}
void Zadacha35()
{
    //Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -99, 99);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] < 100)
            count++;
    }
    Console.WriteLine("Количество элементов массива в отрезке [10,99] равно: " + count);
}
void Zadacha37()
{
    //Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний
    //и т.д. Результат запишите в новом массиве.
    int size = 11;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    int halfsize = size / 2;
    int[] result = new int[halfsize + size % 2];
    int maxIndex = size - 1;
    for (int i = 0; i < halfsize; i++)
    {
        result[i] = numbers[i] * numbers[maxIndex - i];
    }
    if (size % 2 == 1)  result[halfsize] = numbers[halfsize];
    PrintArray(result);
}
//Zadacha31();
//Zadacha32();
//Zadacha33();
//Zadacha35();
Zadacha37();