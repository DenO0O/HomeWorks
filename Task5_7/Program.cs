using System;

namespace Task5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов. Заполнить его случайными числами в диапазоне [0, 10].
            //Определить максимальный элемент в каждой строке
            const int strCount = 10;
            const int colCount = 5;

            Random rnd = new Random();

            int[,] array = new int[strCount, colCount];
            int[] maxList = new int[strCount];

            //Заполнение максимальных значений начальным значением
            for (int i = 0; i < strCount; i++)
            {
                maxList[i] = 0;
            }

            //Заполнение массива
            for (int i = 0; i < strCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    array[i, j] = rnd.Next(0, 11);
                    if (array[i, j] > maxList[i]) maxList[i] = array[i, j];
                    Console.Write($"{array[i, j],3}");
                }
                Console.Write($" | максимум: {maxList[i]}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
