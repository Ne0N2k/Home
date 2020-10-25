using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите большее основание  x:");
            x = double.Parse(Console.ReadLine());

            double y;
            Console.WriteLine("Введите меньшее основание  y:");
            y = double.Parse(Console.ReadLine());

            double z;
            Console.WriteLine("Введите высоту z:");
            z = double.Parse(Console.ReadLine());

            double s;
            s = ((x + y) / 2) + z;

            s = Math.Round(s, 3);

            Console.WriteLine("S = " + s);

            double t;

            t = (x - y) / 2;

            double q;

            q = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(t, 2));

            q = Math.Round(q, 3);

            double p;
            p = x + y + q + q;

            p = Math.Round(p, 3);

            Console.WriteLine("P = " + p);

            Console.ReadKey();


        }
    }
}
