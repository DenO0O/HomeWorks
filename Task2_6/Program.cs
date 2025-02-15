using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах.Округлить длину до 0,5
            Console.Write("Длина: ");
            double l = Convert.ToDouble(Console.ReadLine());

            double result = Math.Round(l * 2) / 2;

            Console.WriteLine($"Округленная длина: {result} м.");
            Console.ReadKey();
        }
    }
}
