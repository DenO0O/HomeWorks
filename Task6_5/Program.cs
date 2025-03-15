using System;
using System.Text.RegularExpressions;

namespace Task6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности номера телефона.
            //Корректный номер имеет формат +7(123)456-78-90

            string[] testInputs = {
                "+7(123)456-78-90",
                "+9(321)556-79-91",
                "+9(321)55678-90",
                "+9(321)556-7890",
                "+9321)556-78-90",
                "+7(123)4f6-78-90",
                "+f(123)456-78-90"
            };

            Regex regex = new Regex(@"^\+[0-9]\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}$");

            foreach (var item in testInputs)
            {
                if (regex.IsMatch(item))
                    Console.WriteLine($"{item} - ok");
                else
                    Console.WriteLine($"{item} - X");
            }
            Console.ReadKey();
        }
    }
}
