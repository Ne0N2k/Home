using System;

namespace Multiplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите m: ");
            var m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите n: ");
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine("Произведение = " + Operator(m, n) + "(Если вы получили 0, введите данные корректно)");
            Console.ReadKey();
        }
 
        public static double Operator(double m, double n)
        {
            if (1 <= m && m <= n && n < 20) 
            {
                return n*m ;
            }
            else
            {
                return 0;
            }
        }
    }

}