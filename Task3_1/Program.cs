using System;

namespace Task3_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=»
            Console.Write("Число 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            string result = "<";
            if (number1 == number2)
                result = "=";
            else if (number1 > number2)
                result = ">";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
