using System;

namespace Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 целых числа, а затем – код операции
            //(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ.
            //Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).

            int a = 0, b = 0, operationId = 0;
            double result = 0.0;

            try
            {
                Console.Write("Число 1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Число 2: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Код операции (1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное): ");
                operationId = Convert.ToInt32(Console.ReadLine());

                switch (operationId)
                {
                    case 1: //сложение
                        result = a + b;
                        break;
                    case 2: //вычитание
                        result = a - b;
                        break;
                    case 3: //произведение
                        result = a * b;
                        break;
                    case 4: //частное
                        if (b == 0) throw new DivideByZeroException();
                        result = (double)a / b;
                        break;
                    default:
                        throw new Exception("Неверный код операции");
                }
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.Write("Введено не число");
            }
            catch (DivideByZeroException)
            {
                Console.Write("Деление на ноль");
            }
            catch (Exception e)
            {
                Console.Write($"Ошибка: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
