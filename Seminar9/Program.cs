namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Решение задачи с треугольником Паскаля
            // int row = 9;
            // int[,] triangle = new int[row, row];
            // const int cellWidth = 5;

            // void FillTriangle()
            // {
            //     for (int i = 0; i < row; i++)
            //     {
            //         triangle[i, 0] = 1;
            //         triangle[i, i] = 1;
            //     }
            //     for (int i = 2; i < row; i++)
            //     {
            //         for (int j = 1; j <= i; j++)
            //         {
            //             triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
            //         }
            //     }
            // }
            // void PrintTriangle()
            // {
            //     for (int i = 0; i < row; i++)
            //     {
            //         for (int j = 0; j < row; j++)
            //         {
            //             if (triangle[i, j] != 0)
            //                 Console.Write($"{triangle[i, j],cellWidth}");

            //         }
            //         Console.WriteLine();
            //     }
            // }
            // void Magic()
            // {
            //     int col = cellWidth * row;
            //     for (int i = 0; i < row; i++)
            //     {
            //         for (int j = 0; j <= i; j++)
            //         {
            //             Console.SetCursorPosition(col, i + 1);
            //             if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            //             col += cellWidth * 2;
            //         }
            //         col = cellWidth * row - cellWidth * (i + 1);
            //         Console.WriteLine();
            //     }
            // }
            // Console.ReadKey();
            // FillTriangle();
            // PrintTriangle();
            // Console.ReadKey();
            // Magic();

            void Zadacha63()
            { //Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                // while (counter <= number)
                // {
                //     Console.Write($"{counter}");
                //     counter++;
                // }
                Recursion(number);

            }
            void Recursion(int number, int counter = 1)
            {
                if (counter > number) return;
                Console.Write($"{counter} ");
                counter++;
                Recursion(number, counter);
            }
            //Zadacha63();
            void Zadacha65()
            {
                // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
                /*Console.WriteLine("Введите число M");
                int numberM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число N");
                int numberN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(NumbersRec(numberM, numberN));
                */
                Console.WriteLine("Введите число M");
                int counter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число M");
                int number = Convert.ToInt32(Console.ReadLine());
                Recursion(number, counter);

            }
            string NumbersRec(int M, int N)
            {
                if (M <= N) return $"{M} " + NumbersRec(M + 1, N);
                else return string.Empty;
            }
            //Zadacha65();
            void Zadacha67()
            { //Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
                Console.WriteLine("Введите число");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SumRec(n));
                Console.WriteLine();
                Console.WriteLine($"Сумма цифр в числе {n} равна: {SumDigits(n)}");
                /*цикл
                int sum = 0;
                int current_number = number;
                while (current_number > 0)
                {
                    sum += current_number % 10;
                    current_number /= 10;
                    Console.WriteLine($"Сумма цифр в числе{number} равна: {sum}");
                }
                */
            }
            int SumRec(int n)
            {
                if (n == 0) return 0;
                else return n % 10 + SumRec(n /= 10);
            }
            int SumDigits(int number, int sum = 0)
            {
                if (number == 0) return sum;
                sum += number % 10;
                number /= 10;
                return SumDigits(number, sum);
            }
            // в обратном порядке складывание чисел в цифре
            int SumDigitsReverse(int number)
            {
                if (number == 0) return 0;
                return number % 10 + SumDigits(number /= 10);
            }
            //Zadacha67();
            void Zadacha69()
            {
                // Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
                Console.WriteLine("Введите число A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число B");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(PowerRec(a, b));
            }
            int PowerRec(int a, int b)
            {
                if (b == 0) return 1;
                else return PowerRec(a, b - 1) * a;
            }
            //Zadacha69();
            void Zadacha3()
            {
                //Двумерный массив размером 5х5 заполнен случайными нулями и единицами. Игрок может ходить только по полям, заполненным единицами. Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).

                int row = 5;
                int column = 5;
                int maxIndexRow = row - 1;
                int maxIndexColumn = column - 1;
                int[,] matrix = new int[row, column];
                FillArray(matrix, 0, 1);
                matrix[0, 0] = 1;
                matrix[maxIndexRow, maxIndexColumn] = 1;
                PrintArray(matrix);
                Console.WriteLine();
                bool find = false;
                PathFind(matrix);
                PrintArray(matrix);
                Console.WriteLine();
                if (find) Console.WriteLine("Путь найден");
                else Console.WriteLine("Пути нет");

                void PathFind(int[,] matrix, int i = 0, int j = 0)
                {
                    if (i < 0 || i > maxIndexRow || j < 0 || j > maxIndexColumn) return;
                    if (matrix[i, j] == 0 || matrix[i, j] == 2) return;

                    matrix[i, j] = 2;
                    if (i == maxIndexRow & j == maxIndexColumn)
                    {
                        find = true;
                        return;
                    }

                    PathFind(matrix, i - 1, j);
                    PathFind(matrix, i + 1, j);
                    PathFind(matrix, i, j - 1);
                    PathFind(matrix, i, j + 1);
                }

            }

            //Zadacha3();
            void Zadacha58()
            {
                // вывод массива по спирали
                int rows = 5;
                int columns = 4;
                int indexRow = 0;
                int indexColumn = 0;
                int biasRow = 0;
                int biasColumn = 1;
                int steps = columns;
                int turn = 0;

                int[,] numbers = new int[rows, columns];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[indexRow, indexColumn] = i + 1;
                    steps--;
                    if (steps == 0)
                    {
                        //steps = columns - 1 - turn / 2;
                        steps= columns*(turn%2) + rows * ((turn +1)%2) -1 - turn / 2;
                        int temp = biasRow;
                        biasRow = biasColumn;
                        biasColumn = -temp;
                        turn++;
                    }
                    indexRow += biasRow;
                    indexColumn += biasColumn;
                }
                PrintArray(numbers);


            }
            //Zadacha58();
            void Zadacha61()
            { // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
                int rowsFirst = 5;
                int columnsFirst = 4;
                int rowsSecond = columnsFirst;
                int columnsSecond = 2;
                int[,] matrixFirst = new int[rowsFirst, columnsFirst];
                int[,] matrixSecond = new int[rowsSecond, columnsSecond];
                int[,] result = new int[rowsFirst, columnsSecond];
                FillArray(matrixFirst);
                FillArray(matrixSecond);
            

                for (int i = 0; i < rowsFirst; i++)
                {
                    for (int j = 0; j < columnsSecond; j++)
                    {
                        for (int k = 0; k < columnsFirst  ; k++)
                        {
                            result[i,j] += matrixFirst[i,k] + matrixSecond[k,j]; 
                        }
                    }
                }

                PrintArray(matrixFirst);
                Console.WriteLine();
                PrintArray(matrixSecond);
                Console.WriteLine();
                PrintArray(result);
            }
            Zadacha61();
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