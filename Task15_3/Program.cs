using System;
using System.Collections.Generic;

namespace Task15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте HashSet для хранения email - подписчиков с регистронезависимым сравнением
            //для регистронезависимости добавлен ToLower() ко всем адресам
            HashSet<string> set = new HashSet<string>();
            set.Add("alice@example.com".ToLower());
            set.Add("bob@example.com".ToLower());
            set.Add("charlie@example.com".ToLower());

            //Попытку добавления дубликата с выводом результата операции
            Console.WriteLine($"Дубликат alice@example.com добавлен? {set.Add("alice@example.com".ToLower())}");

            //Проверку наличия подписчиков в системе
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {set.Contains("bob@example.com".ToLower())}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {set.Contains("dave@example.com".ToLower())}");

            HashSet<string> set2 = new HashSet<string>() {
                "bob@example.com".ToLower(),
                "dave@example.com".ToLower(),
                "eve@example.com".ToLower()
            };

            //Объединение множеств(добавление новых подписчиков)
            var allusers = new HashSet<string>(set);
            allusers.UnionWith(set2);
            Console.WriteLine("Подписчики после объединения:");
            PrintAll(allusers);

            //Поиск пересечения (общих подписчиков)
            var susers = new HashSet<string>(set);
            susers.IntersectWith(set2);
            Console.WriteLine("Общие подписчики:");
            PrintAll(susers);

            //Удаление подписчика
            set.Remove("charlie@example.com".ToLower());

            Console.WriteLine($"Всего подписчиков: {allusers.Count}");

            //Проверку на подмножество
            Console.WriteLine($"susers является подмновжеством allusers? {susers.IsSubsetOf(allusers)}");

            //Очистку всей коллекции
            allusers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {allusers.Count}");

            Console.ReadKey();
        }

        static void PrintAll(HashSet<string> set)
        {
            foreach(string s in set) Console.WriteLine($" {s}");
        }
    }
}
