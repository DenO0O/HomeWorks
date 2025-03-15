using System;

namespace Task6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нужно создать отчёт, который будет содержать информацию о продажах за определённый период
            //    Название отчёта: "Отчёт о продажах за [месяц] [год]".
            //    Информация о продажах:
            //    Общая сумма продаж.
            //    Количество проданных товаров.
            //    Средняя стоимость одного товара.
            //Общая сумма продаж должна быть отформатирована как денежная величина (с разделителями тысяч и двумя знаками после запятой).
            //Средняя стоимость товара должна быть округлена до двух знаков после запятой.

            const int widthDoc = 40; //ширина документа в символах
            string monthName = "Март";
            int year = 2025;
            double money = 1234567.89;
            int salesNumber = 1234;

            Console.WriteLine(new string('-', widthDoc));
            Console.WriteLine($"Отчет о продажах за {monthName} {year}");
            Console.WriteLine(new string('-', widthDoc));
            Console.WriteLine($"Общая сумма продаж: {money:N2} р.");
            Console.WriteLine($"Количество проданных товаров: {salesNumber:N0} шт.");
            Console.WriteLine($"Средняя стоимость товара: {money / salesNumber:N2} р.");
            Console.WriteLine(new string('-', widthDoc));
            Console.ReadKey();
        }
    }
}
