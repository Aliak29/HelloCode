void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.WriteLine("Задача 19.");
    Console.WriteLine("Введите пятизначное число");
    string number = Console.ReadLine();
    if (number[0] == number[4] && number[1]==number[3])
    {
    Console.WriteLine("Данное число палиндром");
    }
    else 
    {
    Console.WriteLine("Данное число не палиндром");
    }
    if (number.Length != 5)
    {
    Console.WriteLine("Неверный ввод");
    }
}
void Zadacha21()
{// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Задача 21.");
    Console.WriteLine("Введите координату х1");
    int numberX1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y1");
    int numberY1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z1");
    int numberZ1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х2");
    int numberX2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y2");
    int numberY2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z2");
    int numberZ2 = Convert.ToInt32(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow((numberX2 - numberX1), 2) + Math.Pow((numberY2 - numberY1), 2) + Math.Pow((numberZ2 - numberZ1), 2));
    Console.WriteLine("Расстояние между точками в 3D равно: " + Math.Round (result, 2));
}
void Zadacha23()
{//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.WriteLine("Задача 23.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int index = 1;
    while (index <= number)
    {
    Console.WriteLine($"{Math.Pow(index, 3)} ");
    index++;
    }
}
//Zadacha19();
//Zadacha21();
Zadacha23();