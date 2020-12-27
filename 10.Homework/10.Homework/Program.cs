using System;

namespace _10.Homework
{
    class Program
    {
        static void Main()
        {
            int a = 0, b = 0;

            var tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine("Введите число строк (a)");
                var input = Console.ReadLine();

                if (int.TryParse(input, out a) && a >= 5 && a <= 20)
                {
                    while (true)
                    {
                        Console.WriteLine("Введите число столбцов (b)");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out b) && b >= 5 && b <= 20)
                        {
                            tryAgain = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода\b");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода\b");
                    continue;
                }
            }

            var rnd = new Random();

            var table = new int[a, b];

            for (var i = 0; i < table.GetLength(0); i++)
                for (var f = 0; f < table.GetLength(1); f++)
                    table[i, f] = rnd.Next(0, 100);

            PrintTable(table);

            Console.WriteLine();

            GetElementsInDescendingOrder(table);

            Console.WriteLine();

            GetDifferenceOfTheSums(table);

            Console.ReadKey();
        }

        static void PrintTable(int[,] q)
        {
            for (var i = 0; i < q.GetLength(0); i++)
            {
                for (var f = 0; f < q.GetLength(1); f++)
                    Console.Write($"{q[i, f],2} ");

                Console.WriteLine();
            }
        }

        static void GetElementsInDescendingOrder(int[,] q)
        {
            for (int i = 0; i < q.GetLength(0); i++)
            {
                for (int f = 0; f < q.GetLength(1); f++)
                {
                    if (f > 0)
                    {
                        if (q[i, f] >= q[i, f - 1])
                        {
                            Console.Write($"{q[i, f],2} ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }

        static void GetDifferenceOfTheSums(int[,] q)
        {
            int First = 0;
            int Second = 0;
            for (int i = 0; i < q.GetLength(0); i++)
            {
                for (int f = 0; f < q.GetLength(1); f++)
                {
                    if (f % 2 == 0)
                        First = First + q[i, f];
                    else
                        Second = Second + q[i, f];
                }

                Console.WriteLine($"{i,2}: {First - Second,3} ");
            }
        }
    }
}
   
