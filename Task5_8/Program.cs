using System;

namespace Task5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10]. Найти два наибольших элемента.
            //Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8. Среди чисел {5, 9, 1, 9, 3}
            //два наибольших числа – 9 и 9

            const int NumCount = 5;
            int[] array = new int[NumCount];
            int[] maxList;

            //Заполнение массива
            Random rnd = new Random();
            for (int i = 0; i < NumCount; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            //Поиск двух максимальных значений
            //будем хранить в первой позиции maxList большее из двух первых значений, во второй меньшее
            maxList = new int[2] { Math.Max(array[0], array[1]), Math.Min(array[0], array[1]) };
            for (int i = 2; i < NumCount; i++) //рассмотрим остальные значения
            {
                if (array[i] > maxList[0]) //Если значение больше чем первое, сохраним его как максимальное,
                                           //а прошлое максимальное запишем как второе значение
                {
                    maxList[1] = maxList[0];
                    maxList[0] = array[i];
                }
                else if (array[i] > maxList[1]) //если значение меньше первого, но больше второго, запишем как второе
                    maxList[1] = array[i];
            }
            Console.WriteLine($"Два максимальных {maxList[0]} и {maxList[1]}");
            Console.ReadKey();
        }
    }
}
