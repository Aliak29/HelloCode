void Zadacha39()
{
    //Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
    //месте, а первый - на последнем и т.д.)
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    /* первый способ разворота массива
    for (int i = size -1; i >= 0; i--)
    {
        Console.Write(numbers[i] + " ");
    }
    */
    // 2 способ
    /*int temp;
    int maxIndex = size - 1;
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[maxIndex - i] + " ");
    }
    */
    // 3 способ - создание нового массива
    /*    int[] result = new int[size];
        int maxIndex = size - 1;
        for (int i = 0; i < size; i++)
        {
            result[maxIndex - i] = numbers[i];
        }
        PrintArray(result);

    */
    // если нужно развернуть большой массив с маленьким количеством свободной памяти
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++) // в 2 раза меньше операций
    {
        // создаем temp в цикле, т.к. после завершения цикла переменная перестает существовать
        /*int temp = numbers[i];
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex - i] = temp;
        */
        // еще один способ кортеж (3,5)
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
    PrintArray(numbers);
}
void FillArray(int[] numbers, int minValue = 0, int maxValue = 9)
{
    Random rand = new Random();
    int length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine("\n"); // переход на новую строку
}

void Zadacha40()
{ //Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
    //Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
    Console.WriteLine("Введите первую сторону треугольника");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вторую сторону треугольника");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третью сторону треугольника");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a < b + c && b < c + a && c < b + a) Console.WriteLine("Трегольник существует");
    else Console.WriteLine("Трегольник не существует");
}
//через кортеж
/*var triangle = (3, 4, 5);
if (triangle.Item1 + triangle.Item2 > triangle.Item3 && triangle.Item1 + triangle.Item3 > triangle.Item2
    && triangle.Item2 + triangle.Item3 > triangle.Item1)
{
    Console.WriteLine("Трегольник существует");
}
else
{
    Console.WriteLine("Трегольник не существует");
}
*/


/*решение через массивы
int size = 3;
int[] number = new int[size];
int[] numberA = new int[size];
FillArray(number);
PrintArray(number);
numberA[0] = number[1] + number[2];
numberA[1] = number[0] + number[2];
numberA[2] = number[0] + number[1];
bool result = false;
for (int i = 0; i < size; i++)
{
if (number[i] < numberA[i]) result = true;
}
if (result) Console.WriteLine($" треугольник со сторонами такой длины может сужествовать");
else Console.WriteLine($" треугольник со сторонами такой длины НЕ может сужествовать");
*/
/*void Zadacha42()
{
    //Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    Console.WriteLine("Введите целое положительное число");
    int numbers = Convert.ToInt32(Console.ReadLine());
    string result = ToBinary(numbers);
    Console.Write($"Число в двоичном виде: {numbers} => {result}");
}
string ToBinary(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}
*/
void Zadacha44()
// {
//     Console.WriteLine("Введите границу чисел фибоначи");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int prev = 0;
//     int prev2 = 1;
//     Console.Write($"{prev} {prev2} ");
//     for (int i = 2; i < max; i++)
//     {
//         int current = prev + prev2;
//         prev = prev2;
//         prev2 = current;
//         Console.Write($"{current} ");
//     }
//     Console.WriteLine();
// }
{
    int count = 5;
    double firstE1 = 0;
    double secondE1 = 1;
    for (int i = 1; i <= count; i++)
    {
        Console.Write(firstE1 + " ");
        // double temp = secondE1;
        // secondE1 = secondE1 + firstE1;
        // firstE1 = temp;
        (firstE1, secondE1) = (secondE1, firstE1 + secondE1);
    }
    Console.WriteLine();
}
void Zadacha45()
{
    //Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    int[] result = new int[size];
    //result = numbers //идет копированние ссылки а не массива
    CoppyArray(numbers, result); //нужнои спользовать данный метод
    PrintArray(result);
}
void CoppyArray(int[] firstArray, int[] secondArray)
{
    int size = firstArray.Length;
    for (int i = 0; i < size; i++)
    {
        secondArray[i] = firstArray[i];
    }
}
//Zadacha39();
//Zadacha40();
//Zadacha42();
//Zadacha42_1();
//Zadacha44();
Zadacha45();