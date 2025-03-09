using System;

namespace Task5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Клеточное поле размером n*n (n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»).
            //Проверить, выиграли ли «крестики»? Считается, что «крестики» выиграли, если на поле найдется горизонталь,
            //вертикали или диагональ из «крестиков».
            const int n = 3;
            int[,] array = new int[n, n];
            bool isXWin = false;

            //Создаем заполненное поле
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            //Проверим все вертикали и горизонтали и основные диагонали на наличие суммы значений всех клеток этих элементов равной n
            int summVertical;
            int summHorisontal;
            int summdiag1 = 0;
            int summdiag2 = 0;
            for (int i = 0; i < n; i++) //для вертикалей i это столбики, для горизонталей i это строки
            {
                summVertical = 0;
                summHorisontal = 0;
                if (array[i, i] == 1) summdiag1++; //диагональ слева-сверху до справа-снизу
                if (array[i, n-i-1] == 1) summdiag2++; //диагональ справа-сверху до слева-снизу

                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] == 1) summVertical++; //вертикали
                    if (array[j, i] == 1) summHorisontal++; //горизонтали
                }
                if (summVertical == n || summHorisontal == n || summdiag1 == n || summdiag2 == n)
                {
                    isXWin = true;
                }
            }
            string result = (isXWin) ? "X выиграли" : "X не выиграли";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
