using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Целочисленная_арифметика
{
    class Program

    {

        static void Main(string[] args)

        {
          
            Console.WriteLine("Введите четырехзначное число: ");



            var n = Convert.ToInt32(Console.ReadLine());
            n = n % 100 * 1000 + n / 1000 % 1000 * 100 + n / 100 % 100 + n / 10 % 10;

            Console.WriteLine(n);

            Console.ReadLine();

            Console.ReadKey();
        }



















    }

    }

