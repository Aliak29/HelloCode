int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}
void Zadacha24()
{
    //: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
    //от 1 до А.
    Console.WriteLine("Задача 24.");
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);
    // 1 2 3 4 5 ... решение с помощью counter/счетчика
    int counter = 1;
    int sum = 0;
    while (counter <= number)
    {
        Console.Write($"{sum} + {counter} = ");
        sum += counter;
        Console.WriteLine(sum);
        counter++;
    }
    Console.WriteLine("Ответ: " + sum);

    Console.WriteLine("Ответ: " + SumNumbers(number));
}
void Zadacha26()
{
    //Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    Console.WriteLine("Задача 26.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    string numberText = Convert.ToString(number);
    Console.WriteLine("Цифр в числе: " + numberText.Length);
}
// длина числа через десятичный логарифм Math.Ceiling - метод округления к большему, т.к.Math.Log10 выдает не целое значение 
//Console.WriteLine("Длина числа равна: " + Math.Ceiling(Math.Log10(number)));
{
    /*Random rand = new Random();
    int number = rand.Next(1, 1000000);
    Console.WriteLine("Введено число: " + number);
    DateTime now = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        string numberText = Convert.ToString(number);
    }
    Console.WriteLine(DateTime.Now - now);

    now = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {

        int length = 0;
        while (number > 0)
        {
            number = number / 10;
            length++;
        }
    }
    Console.WriteLine(DateTime.Now - now);
    /*int result = 0;
    while (number > 0)
    {
        number = number / 10;
        result++;
    }
    Console.WriteLine("Ответ: " + result);
    */
}
void Zadacha28()
{//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

    /* Random rand = new Random();
     int number = rand.Next(1, 100);
     Console.WriteLine("Введено число: " + number);
     int counter = 1;
     int result = 1;
     while (counter <= number)
     {
         Console.Write($"{counter} x {result} = ");
         result = counter * result;
         Console.WriteLine(result);
         counter++;
     }
     Console.WriteLine("Ответ: " + result);

 */
}

void Zadacha30()
{//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
    Console.WriteLine("Задача 30.");
    Random rand = new Random();
    int counter = 1;
    while (counter <= 8)
    {
        Console.Write($"{rand.Next(0, 2)} ");
        counter++;
    }
}
// {
//     Random ramdomizer = new Random();
//     int[] binaries = new int[8];

//     Console.WriteLine("binary array = [ ");
//     for (int i = 0; i < 8; i++)
//     {
//         binaries[i] = ramdomizer.Next(0, 2);
//         Console.Write(binaries[i] + ", ");
//     }
//     Console.WriteLine("]");
// }
// Ctr + K + C - закомментировать несколько строк
// Ctr + K + U - разкомментировать несколько строк

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(0, 2);
    }
}
void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}
{
    /*int size = 8;
    // int[] numbers - контейнер для массива
    Random rand = new Random();
    int[] numbers = new int[size];
    //Console.WriteLine(numbers[7]); 
    for (int i = 0; i < size; i++)
    {
        numbers[i]= rand.Next(0,2);
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    */
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);


}
void ChangeX(int[] y)
{
    y[0]++;
}
void Test()
{
    int[]x={15};
    ChangeX(x);
    Console.WriteLine(x[0]);
}
//Zadacha24();
//Zadacha26();
//Zadacha28();
//Zadacha30();
Test();
