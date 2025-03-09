using System;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
            //Найти и вывести значение максимального, минимального элементов и их индексы
            const int NumCount = 10;
            int[] array = new int[NumCount];
            int[] max; //[значение: индекс]
            int[] min;

            Random rnd = new Random();
            for (int i = 0; i < NumCount; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Зададим начальные значения равными первому элементу
            max = new int[] { array[0], 0 };
            min = new int[] { array[0], 0 };

            for (int i = 1; i < NumCount; i++)
            {
                if (array[i] > max[0])
                {
                    max[0] = array[i];
                    max[1] = i;
                }
                if (array[i] < min[0])
                {
                    min[0] = array[i];
                    min[1] = i;
                }
            }

            Console.WriteLine($"Максимальное: {max[0]} в позиции {max[1]+1}, минимальное {min[0]} в позиции {min[1]+1}.");
            Console.ReadKey();

        }
    }
}
