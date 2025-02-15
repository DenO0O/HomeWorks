using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Длина отрезка задана в дюймах (1 дюйм = 2,54 см). Перевести значение длины в метрическую систему,
            //то есть выразить ее в метрах, сантиметрах и миллиметрах. Например, 21 дюйм = 0 м 53 см 3,4 мм

            Console.Write("Дюймы: ");
            double inches = Convert.ToDouble(Console.ReadLine());

            double milimeters = inches * 25.4 % 10;
            double centimeters = inches * 2.54 % 100;
            double meters = inches * 0.0254;

            Console.WriteLine($"Метров: {Math.Floor(meters)}, сантиметров: {Math.Floor(centimeters)}, милиметров: {Math.Round(milimeters, 1)}");
            Console.ReadKey();
        }
    }
}
