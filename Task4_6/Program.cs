using System;

namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2 - ки ?
            Console.Write("Число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0; //Счтает от степени 0

            while (Math.Pow(2, r) < n)
            {
                r++;
            }

            if (Math.Pow(2, r) == n)
                Console.WriteLine($"{n} это степень 2");
            else
                Console.WriteLine($"{n} это не степень 2");

            Console.ReadKey();
        }
    }
}
