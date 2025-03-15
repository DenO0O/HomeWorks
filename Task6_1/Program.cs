using System;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Найти самое длинное слово в строке.
            Console.Write("Предложение: ");
            string str = Console.ReadLine();
            string[] strList = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (var item in strList)
            {
                if (result.Length < item.Length)
                    result = item;
            }
            Console.Write($"Самое длинное слово: {result}");
            Console.ReadKey();
        }
    }
}
