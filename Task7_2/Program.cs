using System;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте метод CalcCube для вычисления объема и площади поверхности куба по длине его ребра. Метод должен иметь 3
            //параметра - длина ребра, out-параметр для объема и out-параметр для площади поверхности.

            double edgeLength = 5;
            double volume, surfaceArea;
            CalcCube(edgeLength, out volume, out surfaceArea);
            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
            Console.ReadKey();
        }

        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            if (edgeLength > 0)
            {
                volume = Math.Pow(edgeLength, 3);
                surfaceArea = edgeLength * edgeLength * 6;
            }
            else
            {
                volume = 0;
                surfaceArea = 0;
            }
        }
    }
}
