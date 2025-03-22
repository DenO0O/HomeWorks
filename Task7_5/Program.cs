using System;

namespace Task7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите перегруженные методы Multiply, которые могут умножать два числа (целые или дробные) и возвращать результат
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2.5, 3.5));
            Console.ReadKey();
        }

        private static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        private static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }
    }
}
