using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру
            Console.Write("Число: ");
            int digits = Convert.ToInt32(Console.ReadLine());

            int digit1 = digits / 1000;
            int digit2 = digits / 100 % 10;
            int digit3 = digits / 10 % 10; ;
            int digit4 = digits % 10;
            int result = digit1 * 1000 + digit4 * 100 + digit3 * 10 + digit2;

            Console.WriteLine($"=:{result}");
            Console.ReadKey();
        }
    }
}
