using System;

namespace _8._3.Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение a: ");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Значение функции равно: " + ConditionalOperator(a));

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
