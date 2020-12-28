using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");


            int n = new int();
            while (true)
            {
                var UserNumber = (Console.ReadLine());

                if (!int.TryParse(UserNumber, out n) || !(int.Parse(UserNumber) > 0))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                else
                {
                    bool flag = true;
                    while (flag)
                    {
                        n += 1;
                        if (IsNumberPrime(n))
                        {
                            Console.WriteLine("Новое число - " + n);
                            flag = false;
                        }
                    }
                    break;
                }


            }
            static bool IsNumberPrime(int i) //Проверка на то, что число является простым
            {
                for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        return false;
                        break;
                    }
                }
                return true;
            }
        }
    }
}
    

