using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах. Округлить длину до целых в большую сторону
            Console.Write("Длина: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Округленная длина: {Math.Ceiling(l)} м.");
            Console.ReadKey();
        }
    }
}
