using System;

namespace Task13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);
            int m = 0;
            int userinput = -1;
            bool isBreaked = false;

            Console.WriteLine("Угадайте число от 1 до 100 (0 - закончить):");
            while (secretNumber != userinput)
            {
                try
                {
                    Console.Write("> ");
                    userinput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" Введено не число. Попробуйте еще раз");
                    continue;
                }
                if (userinput == 0)
                {
                    isBreaked = true;
                    break;
                }
                m++;
                if (secretNumber > userinput)
                    Console.WriteLine("Больше");
                else if (secretNumber < userinput)
                    Console.WriteLine("Меньше");
            }

            if (isBreaked)
                Console.WriteLine($"Остановлено. Было загадано число {secretNumber}");
            else
                Console.WriteLine($"Число {secretNumber} угадано. Кол-во попыток: {m}");
            Console.ReadKey();
        }
    }
}
