void Zadacha9()
{
    //Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
    Console.WriteLine("Задача 9.");
    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine("Случайное число: " + number);
    int tens = number / 10;
    int ones = number % 10;
    Console.Write("Наибольшая цифра числа: ");
    if (tens > ones)
    {
        Console.WriteLine(tens);
    }
    else
    {
        Console.WriteLine(ones);
    }
}
void Zadacha11()
{
    //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    Console.WriteLine("Задача 11.");
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("Случайное число: " + number);
    Console.WriteLine("Новое число: " + (number/10  + number%10));
}  
void Zadacha12()
{
    //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
    //Если число 2 не кратно числу 1, то программа выводит остаток от деления.
    Console.WriteLine("Задача 12.");
    Console.WriteLine("Введите первое число");
    int numberFirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int numberSecond = Convert.ToInt32(Console.ReadLine());
    int result = numberFirst % numberSecond;

    if (numberFirst % numberSecond == 0) 
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else 
    {
        Console.WriteLine("Второе число не кратно первому, остаток от деления:" + result);
    }
}
void Zadacha14()
{
    //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
    Console.WriteLine("Задача 14.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 7 == 0 & number % 23 == 0)
    {
        Console.WriteLine("Число кратно одновременно 7 и 23");
    }
    else 
    {
        Console.WriteLine("Число не кратно одновременно 7 и 23");
    }
}
void Zadacha16()
{
    //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
    Console.WriteLine("Задача 16.");
    Console.WriteLine("Введите первое число");
    int numberFirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int numberSecond = Convert.ToInt32(Console.ReadLine());
    
    if (numberSecond == numberFirst * numberFirst | numberFirst == numberSecond * numberSecond)

    {
        Console.WriteLine("Одно число является квадратом другого");
    }
    else
    {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }
}

//Zadacha9();  
//Zadacha11();
//Zadacha12();
//Zadacha14();

Zadacha16();