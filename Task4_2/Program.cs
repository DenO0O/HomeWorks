using System;

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n

            Console.Write("Число: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            double result = 1.0;
            for (int i = 2; i <= digit; i++)
            {
                result += 1.0 / i;
            }

            Console.WriteLine($"={result}");
            Console.ReadKey();
        }
    }
}
