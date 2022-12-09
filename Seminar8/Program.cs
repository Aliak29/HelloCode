namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            void TextDoom(int[,] map)
            {
                Random randomizer = new Random();
                var personPosition = (19, 10);
                var treasurePosition = (randomizer.Next(1, 20), randomizer.Next(1, 20));
                int rows = map.GetLength(0);
                int columns = map.GetLength(1);
                int target = 10;
                int counter = 0;
                int headerCount = 4;
                int statString = 2;
                // map section 
                Console.Clear();
                Console.WriteLine("!!! DOOM ZERO !!!");
                Console.WriteLine($"Found treasures {counter}/10");
                Console.WriteLine();
                Console.WriteLine("+--------------------+");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < columns; j++)
                        if (map[i, j] == 0)
                            Console.Write(" ");
                        else if (map[i, j] == 1)
                            Console.Write("*");
                    Console.Write("|");
                    Console.WriteLine();
                }
                Console.WriteLine("+---------  ---------+");
                int treasureLiveTime = 0;
                int maxTreasureLiveTime = 20;
                bool treasureFound = false;
                while (counter < target)
                {
                    Console.SetCursorPosition(personPosition.Item2, headerCount + personPosition.Item1);
                    Console.Write("@");
                    Console.SetCursorPosition(treasurePosition.Item2, headerCount + treasurePosition.Item1);
                    Console.Write("$");
                    if (personPosition.Item1 == treasurePosition.Item1 && personPosition.Item2 == treasurePosition.Item2)
                    {
                        treasureFound = true;
                        counter++;
                    }
                    if (treasureLiveTime == maxTreasureLiveTime || treasureFound)
                    {
                        Console.SetCursorPosition(treasurePosition.Item2, headerCount + treasurePosition.Item1);
                        Console.Write(" ");
                        treasurePosition = (randomizer.Next(1, 20), randomizer.Next(1, 20));
                        treasureFound = false;
                        treasureLiveTime = 0;
                        Console.SetCursorPosition(0, statString - 1);
                        Console.WriteLine($"Found treasures {counter}/10");
                    }
                    treasureLiveTime++;
                    Console.SetCursorPosition(personPosition.Item2, headerCount + personPosition.Item1);
                    ConsoleKey pressedKey = Console.ReadKey().Key;
                    if (pressedKey == ConsoleKey.LeftArrow)
                    {
                        Console.Write(" ");
                        personPosition.Item2 = Math.Max(1, personPosition.Item2 - 1);
                    }
                    else if (pressedKey == ConsoleKey.RightArrow)
                    {
                        Console.Write(" ");
                        personPosition.Item2 = Math.Min(columns, personPosition.Item2 + 1);
                    }
                    else if (pressedKey == ConsoleKey.UpArrow)
                    {
                        Console.Write(" ");
                        personPosition.Item1 = Math.Max(0, personPosition.Item1 - 1);
                    }
                    else if (pressedKey == ConsoleKey.DownArrow)
                    {
                        Console.Write(" ");
                        personPosition.Item1 = Math.Min(rows - 1, personPosition.Item1 + 1);
                    }
                    else if (pressedKey == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Bye!!!");
                        return;
                    }
                }
                Console.Clear();
                Console.WriteLine("!!!\t\t DOOM ZERO\t !!!");
                Console.WriteLine("!!!\t\t YOU WIN\t !!!");
                Console.WriteLine($"!!! Found treasures {counter}\t\t !!!");
                Console.WriteLine("!!! Found secret places - 100%\t !!!");
            }
            //ZadachaPow1();


            void Zadacha53()
            {
                //Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
                //массива.
                int rows = 3;
                int columns = 4;
                int[,] numbers = new int[rows, columns];
                FillArray(numbers, 1, 9);
                PrintArray(numbers);
                int indexMin = 0;
                int indexMax = rows - 1;
                for (int j = 0; j < columns; j++)
                {
                    (numbers[indexMin, j], numbers[indexMax, j]) = (numbers[indexMax, j], numbers[indexMin, j]);
                }
                PrintArray(numbers);
            }
            void Zadacha55()
            {
                //Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
                //невозможно, программа должна вывести сообщение для пользователя.
                int rows = 3;
                int columns = 3;
                int[,] numbers = new int[rows, columns];
                FillArray(numbers, 1, 9);
                PrintArray(numbers);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = i; j < columns; j++)
                    {
                        // int temp = numbers[i, j];
                        // numbers[i, j] = numbers[j, i];
                        // numbers[j, i] = temp;
                        (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
                    }
                }
                PrintArray(numbers);
            }
            void Zadacha57()
            {
                //Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
                //сколько раз встречается элемент входных данных.
                int rows = 5;
                int columns = 5;
                int[,] numbers = new int[rows, columns];
                FillArray(numbers, 0, 9);
                PrintArray(numbers);
                int[] dictionary = new int[10];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dictionary[numbers[i, j]]++;

                    }
                }
                PrintDictionary(dictionary);
            }
            void PrintDictionary(int[] numbers, string message = "Вывод словаря:")
            {
                int rows = numbers.Length;
                Console.WriteLine(message);
                for (int i = 0; i < rows; i++)
                {
                    if (numbers[i] > 0)
                    Console.WriteLine($"число {i} встречается: {numbers[i]} раз(-а)\t");
                }
                Console.WriteLine();
            }
            //Zadacha53();
            //Zadacha55();
            Zadacha57();
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
        static void FillArray(double[,] numbers, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
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
        static void PrintArray(int[] numbers, string message = "Вывод словаря:")
        {
            int rows = numbers.Length;
            Console.WriteLine(message);
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{numbers[i]}\t");
            }
            Console.WriteLine();
        }
        static void PrintArray(double[,] numbers, string message = "Вывод массива:")
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