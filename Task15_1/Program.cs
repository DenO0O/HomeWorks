using System;
using System.Collections.Generic;

namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamers = new List<string>();
            gamers.Add("Иванов");
            gamers.Add("Петров");
            gamers.Add("Сидоров");

            //Вставка игрока "Козлов" на позицию с индексом 1 методом Insert.
            gamers.Insert(1, "Козлов");

            //Проверка наличия игрока "Петров" в команде методом Contains.
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {gamers.Contains("Петров")}");

            //Удаление игрока "Сидоров" методом Remove.
            bool resultRemove = gamers.Remove("Сидоров");

            //Поиск индекса игрока "Козлов" методом IndexOf.
            Console.WriteLine($"Индекс игрока 'Козлов': {gamers.IndexOf("Козлов")}");

            //Сортировка списка по алфавиту методом Sort.
            gamers.Sort();

            // Выведите текущий состав команды
            Console.WriteLine($"Текущий состав команды:");
            for (int i = 0; i < gamers.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {gamers[i]}");
            }

            //Проверьте, пуст ли список (свойство Count), и очистите его методом Clear
            Console.WriteLine($"Команда пуста? {gamers.Count == 0}");
            gamers.Clear();
            Console.WriteLine($"Количество игроков после очистки: {gamers.Count}");
            Console.ReadKey();
        }
    }
}
