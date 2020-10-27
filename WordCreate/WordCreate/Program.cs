using System;

namespace WordCreate
{
    class Program
    {
        static void Main()
        {
            string word = "коронация";

            string word1 = word.Substring(6, 1) + word.Substring(7, 1) + word.Substring(2,1) + word.Substring(0,1);
            Console.WriteLine("Первое слово: " + word1);

            string word2 = word.Substring(1, 1) + word.Substring(0, 1) + word.Substring(3, 1) + word.Substring(2, 1) + word.Substring(3, 1) + word.Substring(0, 1);
            Console.WriteLine("Второе слово: " + word2);
            Console.ReadKey();
        }
    }
}
