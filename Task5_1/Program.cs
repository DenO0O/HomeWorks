using System;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
            //Определить, каких чисел больше – четных или нечетных
            const int NumCount = 10;
            int[] array = new int[NumCount];
            int a = 0; //a - кол-во чётных, b - нечетных.
            int b = 0;
            Random rnd = new Random();
            for (int i = 0; i < NumCount; i++)
            {
                array[i] = rnd.Next(0, 101);
                if (array[i] % 2 == 0)
                    a++;
                else
                    b++;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            string str = "Четных и нечетных равное количество";
            if (a > b) str = "Четных больше";
            else if (a < b) str = "Нечетных больше";

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
