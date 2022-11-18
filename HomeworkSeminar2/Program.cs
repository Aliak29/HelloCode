void Zadacha10()
{
    //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("Задача 10.");
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int tens = number / 10;
    int ones = tens % 10;
    if (number > 99 & number < 1000)
    {
        Console.WriteLine("Вторая цифра числа " + ones);
    }
    else
    {
        Console.WriteLine("Это не трехзначное число");
    }
}
void Zadacha13()
{
    //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    Console.WriteLine("Задача 13.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    string numberText = Convert.ToString(number);
    if (numberText.Length > 2)
    {
    Console.WriteLine("Третья цифра: " + numberText[2]);
    }
    else 
    {
    Console.WriteLine("Третьей цифры нет");
    }
    // Как выполнить эту задачу через деление, как Вы говорили на семинаре, к сожалению, не смогла понять
}
void Zadacha15()
{
    //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    Console.WriteLine("Задача 15.");
    Console.WriteLine("Введите номер дня недели");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной день");
    }  
    else if (number > 0 && number <= 5)
    {
        Console.WriteLine("Это будний день");
    } 
    else   
    {
        Console.WriteLine("Введите цифру от 1 до 7");
    }     
}
//Zadacha10(); 
//Zadacha13();
Zadacha15();