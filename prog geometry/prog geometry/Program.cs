using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите основание x:");
            x = double.Parse(Console.ReadLine());
            
            

            double y;
            Console.WriteLine("Введите основание y:");
            y = double.Parse(Console.ReadLine());


            double z;
            Console.WriteLine("Введите высоту z:");
            z = double.Parse(Console.ReadLine());


            double S;

            S = (((x + y) / 2) + z);
            S=Math.Round(S, 3);

            Console.WriteLine("S = " + S);

            double t;

            t = (x - y) / 2;

            t = Math.Round(t, 3);


            double q;

            q = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(t, 2));

            q = Math.Round(q, 3);


            double P;

            P = x + y + q + q;

            P= Math.Round(P, 3);

            Console.WriteLine("P = " + P);









            Console.ReadKey();
        }
    }
}
