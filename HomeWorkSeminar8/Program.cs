namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha54()
            {//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
                Console.WriteLine("Задача 54.");
                int rows = 3;
                int columns = 4;
                int[,] numbers = new int[rows, columns];
                FillArray(numbers, 0, 9);
                PrintArray(numbers);
                OrderArray(numbers);
                PrintArray(numbers);
            }
            void OrderArray(int[,] numbers)
            {
                int rows = numbers.GetLength(0);
                int columns = numbers.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < columns - 1; k++)
                        {
                            if (numbers[i, k] < numbers[i, k + 1])
                            {
                                int temp = numbers[i, k + 1];
                                numbers[i, k + 1] = numbers[i, k];
                                numbers[i, k] = temp;
                            }
                        }
                    }
                }
            }
            void Zadacha56()
            { //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
                Console.WriteLine("Задача 56.");
                int rows = 4;
                int columns = 5;
                int[,] numbers = new int[rows, columns];
                FillArray(numbers, 0, 9);
                PrintArray(numbers);
                int MinSum = 0;
                int sum = SumRowElements(numbers, 0);
                for (int i = 1; i < rows; i++)
                {
                    int tempSum = SumRowElements(numbers, i);
                    if (sum > tempSum)
                    {
                        sum = tempSum;
                        MinSum = i;
                    }
                }
                Console.WriteLine($"Cтрокa с наименьшей суммой элементов => {MinSum + 1}, где сумма составляет=> {sum}");

            }
            int SumRowElements(int[,] numbers, int i)
            {
                int sum = numbers[i, 0];
                for (int j = 1; j < numbers.GetLength(1); j++)
                {
                    sum += numbers[i, j];
                }
                return sum;
            }
            void Zadacha58()
            { //Заполните спирально массив 4 на 4 числами от 1 до 16.
                Console.WriteLine("Задача 58.");
                int rows = 4;
                int columns = 4;
                int[,] numbers = new int[rows,columns];
                int temp = 1;
                int i = 0;
                int j = 0;
                while (temp <= rows * columns)
                {
                    numbers[i, j] = temp;
                    temp++;
                    if (i <= j + 1 && i + j < columns - 1)
                        j++;
                    else if (i < j && i + j >= rows - 1)
                        i++;
                    else if (i >= j && i + j > columns - 1)
                        j--;
                    else
                        i--;
                }
                PrintArray(numbers);
            }
            //Zadacha54();
            //Zadacha56();
            Zadacha58();

        }
        #region FillArray
        static void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
        {
            maxValue++;
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }
        #endregion
        #region PrintArray
        static void PrintArray(int[,] numbers, string message = "Вывод массива:")
        {
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            Console.WriteLine(message);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
    }
}