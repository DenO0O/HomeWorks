using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросите у пользователя имя, возраст и город. Сформируйте строку в формате:
            //"Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.

            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Город: ");
            string cityName = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Имя: ");
            sb.Append(name);
            sb.Append(", Возраст: ");
            sb.Append(age);
            sb.Append(", Город: ");
            sb.Append(cityName);

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
