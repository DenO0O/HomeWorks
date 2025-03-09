using System;

namespace Task5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив вида
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1

            const int NumCount = 5;
            int[,] array = new int[NumCount, NumCount];
            int val = 1;

            for (int i = 0; i < NumCount; i++)
            {
                for (int j = 0; j < NumCount; j++)
                {
                    array[i, j] = val;
                    val = (val == 0) ? 1 : 0;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
