using System;

namespace Task7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод FindMax, который принимает переменное количество чисел и возвращает максимальное значение.
            //Используйте ключевое слово params

            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");
            Console.ReadKey();
        }

        private static int FindMax(params int[] v1)
        {
            int maxNumber = 0;
            if (v1.Length > 0)
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    if (v1[i] > maxNumber) maxNumber = v1[i];
                }
            }
            return maxNumber;
        }
    }
}
