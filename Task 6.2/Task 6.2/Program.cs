using System;

namespace Task_6._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координату x: ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y: ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("Принадлежит ли точка области? - " + PointInArea(x, y));

            Console.ReadKey();
        }

        static bool PointInArea(double x, double y)
        {
            return  -2 <= y && y <= 1.5;          
        }

    }
}
