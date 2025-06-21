using System;

namespace Task5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
            //Перевернуть массив, т.е. переставить элементы массива в обратном порядке

            const int NumCount = 10;
            int[] array = new int[NumCount];
            int temp;

            Random rnd = new Random();
            for (int i = 0; i < NumCount; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Разворот элементов
            for (int i = 0; i < NumCount / 2; i++)
            {
                temp = array[i];
                array[i] = array[NumCount - 1 - i];
                array[NumCount - 1 - i] = temp;
            }

            //Вывод результата
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
