using System;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Два треугольника заданы длинами своих сторон. Определите, площадь какого из них больше
            //(создайте метод Square для вычисления площади треугольника по длинам его сторон).  Для решения задачи можно
            //использовать формулу Герона.

            double[] figure1 = new double[3];
            double[] figure2 = new double[3];
            Console.Write("Треугольник 1. Сторона А: ");
            figure1[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Треугольник 1. Сторона B: ");
            figure1[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Треугольник 1. Сторона C: ");
            figure1[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Треугольник 2. Сторона А: ");
            figure2[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Треугольник 2. Сторона B: ");
            figure2[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Треугольник 2. Сторона C: ");
            figure2[2] = Convert.ToDouble(Console.ReadLine());

            double figure1Square = Square(figure1);
            double figure2Square = Square(figure2);
            string result = "1 равна площади треугольника 2";

            if (figure1Square > figure2Square) result = "1 больше";
            else if (figure1Square < figure2Square) result = "2 больше";

            Console.WriteLine($"Площадь треугольника {result}");
            Console.ReadKey();
        }

        static double Square(double[] figure)
        {
            //Вычисление площади по формуле Герона
            double p = (figure[0] + figure[1] + figure[2]) / 2;
            return Math.Sqrt(p * (p - figure[0]) * (p - figure[1]) * (p - figure[2]));
        }
    }
}
