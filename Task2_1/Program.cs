using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три числа.Обменять их местами циклически. Например, вводятся a = 1, b = 2, c = 3.
            //После обмена в переменных должны оказаться значения a = 3, b = 1, c = 2
            Console.Write("Число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int d;
            d = c;
            c = b;
            b = a;
            a = d;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
