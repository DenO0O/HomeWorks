using System;

namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            Console.Write("Число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double value = n; //промежуточное значение
            int i = 0; //счетчик

            do
            {
                value /= 10;
                i++;
            }
            while (value > 1);

            Console.WriteLine($"Кол-во цифр в числе {n}: {i} шт.");
            Console.ReadKey();

        }
    }
}
