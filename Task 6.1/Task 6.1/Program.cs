using System;

namespace Task_6._1
{
    class Program
    {
        static void Main()
        {
            var a = GetNumber("m");
            var b = GetNumber("n");

            string answer = "Нет";

            if (EvaluateLogicalExpression(a, b))
                answer = "Да";
            if (LogicalExpression(a,b))
                    answer = "Да";

            Console.WriteLine("Верно ли, что только одно из чисел m или n меньше 20? - " + answer);

            Console.ReadKey();
        }

        static bool EvaluateLogicalExpression(int m, int n)
        {
           
            return  m < 20 && n > 20;
        }

        static bool LogicalExpression(int m, int n )
        {

            return m > 20 && n < 20;
        }

        static int GetNumber(string number)
        {
            Console.WriteLine("Введите число " + number);
            return int.Parse(Console.ReadLine());
        }
    }
   
}
