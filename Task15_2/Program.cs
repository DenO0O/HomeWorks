using System;
using System.Collections.Generic;

namespace Task15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goods = new Dictionary<string, int>();

            goods.Add("A001", 10);
            goods.Add("B205", 25);
            goods.Add("C307", 15);

            //Проверьте наличие товара с артикулом "B205" (ContainsKey).
            Console.WriteLine($"Есть ли товар с артикулом B205? {goods.ContainsKey("B205")}");

            //Обновите количество ноутбуков до 8(продали 2 шт.) через индексатор.
            goods["A001"] = 8;

            //Получите количество наушников безопасным способом (TryGetValue).
            if (goods.TryGetValue("C307", out int value))
                Console.WriteLine($"Количество наушников: {value}");

            //Увеличьте количество смартфонов на 5 (новый завоз).
            goods["B205"] += 5;

            //Удалите наушники из инвентаря (Remove).
            goods.Remove("C307");

            //Выведите текущий инвентарь
            Console.WriteLine($"Текущий инвентарь:");
            foreach (var g in goods)
            {
                Console.WriteLine($"Артикул: {g.Key}, Количество: {g.Value}");
            }

            //Проверьте, пуст ли словарь (Count), затем полностью очистите инвентарь (Clear)
            Console.WriteLine($"Инвентарь пуст? {goods.Count == 0}");
            goods.Clear();
            Console.WriteLine($"Количество товаров после очистки: {goods.Count}");
            Console.ReadKey();
        }
    }
}
