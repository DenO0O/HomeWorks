using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование
            //числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома»,
            //41 — «Мы построили 41 дом».
            Console.Write("Кол-во домов:");
            int n = Convert.ToInt32(Console.ReadLine());
            string s = "";
            if (n % 100 >= 11 && n % 100 <= 20) { s = "домов"; }
            else if (n % 10 == 1 ) { s = "дом"; }
            else if (n % 10 >= 2 && n % 10 <= 4) { s = "дома"; }
            else { s = "домов"; }

            Console.WriteLine("Мы построили {0} {1}.", n, s);
            Console.ReadKey();
        }
    }
}
