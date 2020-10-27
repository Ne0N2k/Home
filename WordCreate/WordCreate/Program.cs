using System;

namespace WordCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первоначальное слово: Коронация ");
            string str = "Ц" + "и" + "р" + "к";
            System.Console.WriteLine("Первое полученное слово: " + str);

            string Newstr = "О" + "к" + "о" + "р" + "о" + "к";
            System.Console.WriteLine("Второе полученное слово: " + Newstr);
            Console.ReadKey();
        }
    }
}
