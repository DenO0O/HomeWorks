using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся два числа. Обменять их местами, не используя третью переменную
            Console.Write("Число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Число1: {a}, число2: {b}");
            Console.ReadKey();
        }
    }
}
