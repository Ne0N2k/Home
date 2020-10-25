using System;
using System.Runtime.CompilerServices;

namespace Метод_Функция
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var x = GetValue();

                Console.WriteLine("x = " + x);

                Console.ReadKey();
            }

            static double GetValue()
            {
                return F(11, 11) + F(7, 7) + F(5, 5);
            }

            /// <summary>
            /// Вычисление повторяющегося выражения
            /// </summary>
            /// <param name="a">Константа под корнем</param>
            /// <param name="b">Знаменатель дроби</param>
            /// <returns></returns>
            static double F(double a, double b)
            {
                return Math.Sqrt(a) * (Math.Sin(5)-Math.Cos(6))/ b + Math.Sqrt(a) * (Math.Sin(3) - Math.Cos(4)) / b + Math.Sqrt(a) * (Math.Sin(2) - Math.Cos(3)) / b;
            }
        }
    }
}
