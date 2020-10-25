using System;
using System.Numerics;

namespace Метод_функция
{
    class Program
    {

        static void Main()
        {
            var x = GetValue();

            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }


        static double GetValue()
        {
            return -F(3, 5) - F(4, 7) - F(6, 11) + F(2, 5) + F(3, 7) + F(5, 11);


        }
        
       
        /// <summary>
        /// Вычисление повторяющегося выражения
        /// </summary>
        /// <param name="a">Константа Cos</param>
        /// <param name="b">Знаменатель дроби под корнем</param>
        /// <returns></returns>
        static double F(double a, double b)
        {
            return (
        }
    }
}




