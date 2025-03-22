using System;

namespace Task7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод PrintNumbers, который выводит на экран числа из массива. У метода должен быть необязательный параметр
            //reverse, который по умолчанию равен false. Если reverse равен true, числа выводятся в обратном порядке.

            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers); // Вывод: 1 2 3 4 5
            Console.WriteLine();
            PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
            Console.ReadKey();
        }

        private static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            else
            {
                foreach (int number in numbers)
                    Console.Write($"{number} ");
            }
        }
    }
}
