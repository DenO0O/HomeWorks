using System;

namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три числа. Вывести большее их них.
            Console.Write("Число 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 3:");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 > number2) ? number1 : number2;
            result = (result > number3) ? result : number3;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
