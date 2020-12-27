using System;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var n = int.Parse(Console.ReadLine());
            n = n / 100 + n % 100 * 100;
            Console.WriteLine(n);
        }
    }
}
