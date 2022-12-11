namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha64()
            {//Задайте значения M и N. Напишите рекурсивный метод, который выведет 
             //все натуральные числа кратные 3-ём в промежутке от M до N.
                Console.WriteLine("Задача 64.");
                Console.WriteLine("Введите число M");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число N");
                int n = Convert.ToInt32(Console.ReadLine());
                NumbersRec(n, m);
            }
            void NumbersRec(int number, int counter)
            {
                if (counter > number) return;
                if (counter % 3 == 0)
                Console.Write($"{counter} ");
                counter++;
                NumbersRec(number, counter);
            }
            void Zadacha66()
            {
                //Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N
                Console.WriteLine("Задача 66.");
                Console.WriteLine("Введите число M");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число N");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SumRec(m, n));
            }
            int SumRec(int m, int n)
            {
                if (m == n) return n;
                return n + SumRec(m, n - 1);
            }
            void Zadacha68()
            {
                //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
                Console.WriteLine("Задача 68.");
                Console.WriteLine("Введите число M");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число N");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(AkkermanRec(m, n));
            }
            int AkkermanRec(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                if (m > 0 && n == 0)
                    return AkkermanRec(m - 1, 1);
                else
                    return AkkermanRec(m - 1, AkkermanRec(m, n - 1));
            }
            //Zadacha64();
            //Zadacha66();
            Zadacha68();
        }
    }
}