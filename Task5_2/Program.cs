using System;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20].
            //Определить количество положительных, отрицательных и равных нулю элементов
            const int NumCount = 10;
            int[] array = new int[NumCount];
            int countPositive = 0;
            int countNegative = 0;
            int countZero = 0;
            Random rnd = new Random();
            for (int i = 0; i < NumCount; i++)
            {
                array[i] = rnd.Next(-20, 21);
                if (array[i] > 0)
                    countPositive++;
                else if (array[i] < 0)
                    countNegative++;
                else
                    countZero++;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Положительных: {countPositive}, отрицательных: {countNegative}, нулевых: {countZero}.");
            Console.ReadKey();
        }
    }
}
