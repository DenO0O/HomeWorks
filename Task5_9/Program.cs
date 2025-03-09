﻿using System;

namespace Task5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Матрицу A(m,n) (m и n – константы со значением на ваш выбор) заполнить натуральными числами от 1 до n*m по спирали,
            //начинающейся в левом верхнем углу и закрученной по часовой стрелке

            const int m = 5;
            const int n = 3;
            int[,] array = new int[m, n];

            int x = 0; //Текущая координата ячейки по x
            int y = 0; //Текущая координата ячейки по y
            int dx = 1; //Приращение x (1 - вправо; 0 - не меняет; -1 - влево)
            int dy = 0; //Приращение y (1 - вниз; 0 - не меняет; -1 - вверх)
            int minX = -1; //Минимальный индекс колонки (-1, т.к. после первой строки ячеек границу поставим на начало)
            int minY = 0; //Минимальный индекс строки
            int maxX = m - 1; //Максимальный индекс колонки (на 1 меньше кол-ва)
            int maxY = n - 1; //Максимальный индекс строки (на 1 меньше кол-ва)

            //Первую ячейку заполним отдельно, т.к. в цикле меняется минимальный индекс
            array[x, y] = 1;
            if (x == maxX) { dx = 0; dy = 1; }

            //цикл по всем остальным ячейкам
            for (int i = 1; i < m * n; i++)
            {
                x += dx;
                y += dy;
                array[x, y] = i + 1;

                //На углах меняем приращение координат и двигаем минимальную/максимальную координату к центру
                if (x == maxX && y == minY) { dx = 0; dy = 1; minX++; }
                if (x == maxX && y == maxY) { dx = -1; dy = 0; minY++; }
                if (x == minX && y == maxY) { dx = 0; dy = -1; maxX--; }
                if (x == minX && y == minY) { dx = 1; dy = 0; maxY--; }
            }

            //Показываем результат
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[j, i],5}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
