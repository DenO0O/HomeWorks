using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст (шифруются только латинские символы):");
            string str = Console.ReadLine().ToUpper();
            string outStr = GetAtbashString(str);
            string initStr = GetAtbashString(outStr);

            Console.WriteLine($"Шифрованный вариант: {outStr}");
            Console.WriteLine($"Расшифрованный вариант: {initStr}");
        }

        static string GetAtbashString(string str)
        {
            const string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int m = abc.Length;
            int abc_index;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                abc_index = abc.IndexOf(str[i].ToString());

                //Если символ не является латинской буквой просто скопируем его, иначе возьмем символ с таким же индексом от конца алфавита
                if (abc_index == -1)
                    sb.Append(str[i].ToString());
                else
                    sb.Append(abc[m - abc_index - 1].ToString());
            }
            return sb.ToString();
        }
    }
}
