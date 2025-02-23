using System;

namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например:
            //256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать». Если пользователь введёт данные
            //не соответствующие условию задачи - выдать сообщение об ошибке.

            Console.Write("Число от 100 до 999:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 100 || n > 999)
            {
                Console.WriteLine("Число не в диапазоне от 100 до 999");
            }
            else
            {
                int digit1 = n / 100;
                int digit23 = n % 100; //Две последние цифры
                int digit2 = n / 10 % 10;
                int digit3 = n % 10;

                string word1 = "";
                string word23 = "";
                string word2 = "";
                string word3 = "";
                switch (digit1)
                {
                    case 1:
                        word1 = "Сто";
                        break;
                    case 2:
                        word1 = "Двести";
                        break;
                    case 3:
                        word1 = "Триста";
                        break;
                    case 4:
                        word1 = "Четыреста";
                        break;
                    case 5:
                        word1 = "Пятьсот";
                        break;
                    case 6:
                        word1 = "Шестьсот";
                        break;
                    case 7:
                        word1 = "Семьсот";
                        break;
                    case 8:
                        word1 = "Восемьсот";
                        break;
                    case 9:
                        word1 = "Девятьсот";
                        break;
                }

                if (digit2 == 1)
                {
                    switch (digit3)
                    {
                        case 1:
                            word23 = "одинадцать";
                            break;
                        case 2:
                            word23 = "двенадцать";
                            break;
                        case 3:
                            word23 = "тринадцать";
                            break;
                        case 4:
                            word23 = "четырнадцать";
                            break;
                        case 5:
                            word23 = "пятнадцать";
                            break;
                        case 6:
                            word23 = "шестнадцать";
                            break;
                        case 7:
                            word23 = "семнадцать";
                            break;
                        case 8:
                            word23 = "восемнадцать";
                            break;
                        case 9:
                            word23 = "девятнадцать";
                            break;
                    }
                }
                else
                {
                    switch (digit2)
                    {
                        case 2:
                            word2 = "двадцать";
                            break;
                        case 3:
                            word2 = "тридцать";
                            break;
                        case 4:
                            word2 = "сорок";
                            break;
                        case 5:
                            word2 = "пятьдесят";
                            break;
                        case 6:
                            word2 = "шестьдесят";
                            break;
                        case 7:
                            word2 = "семьдесят";
                            break;
                        case 8:
                            word2 = "восемдесят";
                            break;
                        case 9:
                            word2 = "девяносто";
                            break;
                        default:
                            word2 = "";
                            break;
                    }

                    switch (digit3)
                    {
                        case 1:
                            word3 = "один";
                            break;
                        case 2:
                            word3 = "два";
                            break;
                        case 3:
                            word3 = "три";
                            break;
                        case 4:
                            word3 = "четыре";
                            break;
                        case 5:
                            word3 = "пять";
                            break;
                        case 6:
                            word3 = "шесть";
                            break;
                        case 7:
                            word3 = "семь";
                            break;
                        case 8:
                            word3 = "восемь";
                            break;
                        case 9:
                            word3 = "девять";
                            break;
                        default:
                            word3 = "";
                            break;
                    }
                }

                Console.WriteLine((digit2 == 1) ? $"{word1} {word23}": $"{word1} {word2} {word3}");
                Console.ReadKey();
            }
        }
    }
}
