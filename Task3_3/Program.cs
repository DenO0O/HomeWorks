using System;

namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        { //Вводятся четыре числа. Вывести большее из них.
            Console.Write("Число 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 3:");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 4:");
            double number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 > number2) ? number1 : number2;
            result = (result > number3) ? result : number3;
            result = (result > number4) ? result : number4;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
