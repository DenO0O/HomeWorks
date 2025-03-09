using System;

namespace Task5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне[-50, 50].
            //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            //Вывести отсортированный таким образом массив на экран

            const int NumCount = 10;
            int[] array = new int[NumCount];
            int temp;

            Random rnd = new Random();
            for (int i = 0; i < NumCount; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Сортировки
            for (int i = 0; i < NumCount / 2 - 1; i++)
            {
                for (int j = i + 1; j < NumCount / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = NumCount / 2; i < NumCount - 1; i++)
            {
                for (int j = i + 1; j < NumCount; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
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
