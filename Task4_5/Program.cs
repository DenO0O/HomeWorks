using System;

namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
            int a;
            do
            {
                Console.Write("Число от 20 до 60: ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a<=20 || a>=60);
            Console.ReadKey();
        }
    }
}
