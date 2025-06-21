using System;

namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три разных числа. Вывести медиану – среднее по величине число.
            Console.Write("Число 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 3:");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double median = 0.0;
            //сравниваем каждое число с двумя другими. Ищем то, которое между двумя по значению.
            if ((number1 >= number2 && number2 >= number3) || (number3 >= number2 && number2 >= number1))
                median = number2;
            else if ((number1 >= number3 && number3 >= number2) || (number2 >= number3 && number3 >= number1))
                median = number3;
            else if ((number2 >= number1 && number1 >= number3) || (number2 >= number1 && number1 >= number3))
                median = number1;

            Console.WriteLine("Медиана чисел: {0}", median);
            Console.ReadKey();
        }
    }
}
