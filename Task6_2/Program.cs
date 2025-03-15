using System;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не
            //используются. Составить программу, определяющую, является ли строка палиндромом без учёта пробелов и регистра
            //(пример палиндрома – «А роза упала на лапу Азора»)

            Console.Write("Предложение: ");
            string str = Console.ReadLine().ToLower();
            string strWOSpaces = str.Replace(" ", ""); //Строка без пробелов
            string resultPart = ""; //Часть строки сообщения результата

            //Сравнение символов с начала и с конца строки
            int strLenght = strWOSpaces.Length;
            for (int i = 0; i < strLenght / 2; i++)
            {
                if (strWOSpaces[i] != strWOSpaces[strLenght - i - 1])
                {
                    resultPart = "не";
                    break;
                }
            }

            Console.WriteLine($"Предложение {resultPart}является палиндромом.");
            Console.ReadKey();
        }
    }
}
