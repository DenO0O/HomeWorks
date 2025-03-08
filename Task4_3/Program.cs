using System;

namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
            Console.Write("Число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = a;
            for (int i = 2; i <= b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"={result}");
            Console.ReadKey();
        }
    }
}
