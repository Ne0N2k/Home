using System;

namespace Целочисленная_арифметика1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите значение x");
                var x = double.Parse(Console.ReadLine());

                var y = F(x);

                Console.WriteLine("f(x) = " + y);
                Console.ReadKey();
            }

            static double F(double x)
            {
                return (1 / (Math.Pow(x, 2) + (1 / (Math.Pow(x, 2) + (1 / (Math.Pow(x, 2) + 1))))));
            }
        }
    }
}
