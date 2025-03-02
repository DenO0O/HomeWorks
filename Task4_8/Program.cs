using System;

namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно. Не использовать строки
            Console.Write("Число: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            int lastD; //временное значение
            int result = 0; //для собирания результата

            do
            {
                lastD = digit % 10; //получим последнюю цифру числа
                digit /= 10; //удалим последнюю цифру из числа целочисленным делением
                result = result * 10 + lastD; //увеличим результат на 10 и добавим сохраненную поледнюю цифру
            }
            while (digit > 0); //продолжаем пока число больше 0

            Console.WriteLine($"{result}");
            Console.ReadKey();
        }
    }
}
