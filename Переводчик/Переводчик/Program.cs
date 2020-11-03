using System;


namespace Переводчик
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст: ");
            string lineRus = Console.ReadLine();

            string lineCS = alphabetCS(lineRus);
      
            Console.WriteLine("Новый текст: "+ lineCS);

            Console.ReadKey();
        }
        static string alphabetCS(string str)
        {
            str = str.Replace("А", "4");
            str = str.Replace("Б", "8");
            str = str.Replace("В", "(");
            str = str.Replace("Г", "r");
            str = str.Replace("Д", "D");
            str = str.Replace("Е", "E");
            str = str.Replace("Ё", "E");
            str = str.Replace("Ж", "}|{");
            str = str.Replace("З", "3");
            str = str.Replace("И", "u");
            str = str.Replace("Й", "u*");
            str = str.Replace("К", "K");
            str = str.Replace("Л", "JI");
            str = str.Replace("М", "M");
            str = str.Replace("Н", "H");
            str = str.Replace("О", "O");
            str = str.Replace("П", "n");
            str = str.Replace("Р", "P");
            str = str.Replace("С", "C");
            str = str.Replace("Т", "T");
            str = str.Replace("У", "Y");
            str = str.Replace("Ф", "cp");
            str = str.Replace("Х", "X");
            str = str.Replace("Ц", "L|");
            str = str.Replace("Ч", "4");
            str = str.Replace("Ш", "LLI");
            str = str.Replace("Щ", "LLL");
            str = str.Replace("Ъ", "`b");
            str = str.Replace("Ы", "bI");
            str = str.Replace("Ь", "b");
            str = str.Replace("Э", "-)");
            str = str.Replace("Ю", "IO");
            str = str.Replace("Я", "9I");

            str = str.Replace("а", "4");
            str = str.Replace("б", "8");
            str = str.Replace("в", "(");
            str = str.Replace("г", "r");
            str = str.Replace("д", "D");
            str = str.Replace("е", "E");
            str = str.Replace("ё", "E");
            str = str.Replace("ж", "}|{");
            str = str.Replace("з", "3");
            str = str.Replace("и", "u");
            str = str.Replace("й", "u*");
            str = str.Replace("к", "K");
            str = str.Replace("л", "JI");
            str = str.Replace("м", "M");
            str = str.Replace("н", "H");
            str = str.Replace("о", "O");
            str = str.Replace("п", "n");
            str = str.Replace("р", "P");
            str = str.Replace("с", "C");
            str = str.Replace("т", "T");
            str = str.Replace("у", "Y");
            str = str.Replace("ф", "cp");
            str = str.Replace("х", "X");
            str = str.Replace("ц", "L|");
            str = str.Replace("ч", "4");
            str = str.Replace("ш", "LLI");
            str = str.Replace("щ", "LLL");
            str = str.Replace("ъ", "`b");
            str = str.Replace("ы", "bI");
            str = str.Replace("ь", "b");
            str = str.Replace("э", "-)");
            str = str.Replace("ю", "IO");
            str = str.Replace("я", "9I");

            return str;
        }


    }
}
