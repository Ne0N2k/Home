using System;

namespace Conditional_operator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x: ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Значение функции равно: " + ConditionalOperator(x));

            Console.ReadKey();
        }

        public static double ConditionalOperator(double x)
        {
            if (Math.Abs(x) > 1)
            {
                return 1;
            }
            else
            {
                if (0 < Math.Abs(x) && Math.Abs(x) <= 1)
                {
                    return Math.Abs(x);
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}


 

