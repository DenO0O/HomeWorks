using System;

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6
            Console.Write("Число: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            double result = 1;
            for (int i = 2; i <= digit; i++)
            {
                result *= i;
            }

            Console.WriteLine($"{digit}!={result}");
            Console.ReadKey();
        }
    }
}
