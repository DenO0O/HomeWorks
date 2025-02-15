using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Угол а задан в градусах, минутах и секундах. Найти его величину в радианах.
            //(???)Рекомендации по тестированию: проверить работоспособность программы для углов, больших развернутого

            Console.Write("Градусы: ");
            int degrInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минуты: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Секунды: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double radians = (degrInt + minutes / 60 + seconds / 3600) * Math.PI / 180;

            Console.WriteLine("Значение в радианах: {0}", radians);
            Console.ReadKey();
        }
    }
}
