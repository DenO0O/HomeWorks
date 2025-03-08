using System;

namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно ли на прямоугольном участке застройки размером a *b метров разместить два дома размером
            //в плане p *q и r *s метров? Дома можно располагать только параллельно сторонам участка. Дома могут
            //стоять «вплотную» друг к другу.
            Console.Write("Размер участка a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер участка b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер дома N1 p:");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер дома N1 q:");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер дома N2 r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер дома N2 s:");
            double s = Convert.ToDouble(Console.ReadLine());

            //Если поставим первый дом в угол, то для второго дома остатки прилежащих размеров площадки составят.
            //Вариант 1:
            double V1_SizeА = a - p;
            double V1_SizeB = b - q;
            //Вариант 2 (если первый дом повернут на 90 градусов):
            double V2_SizeА = a - q;
            double V2_SizeB = b - p;

            //Проверим что второй дом помещается (fits) в предоставленном размере в первом варианте
            bool isFitsInSizeA_v11 = V1_SizeА >= r && b >= s;
            bool isFitsInSizeB_v11 = V1_SizeB >= r && a >= s;
            // с поворотом на 90 градусов
            bool isFitsInSizeA_v12 = V1_SizeА >= s && b >= r;
            bool isFitsInSizeB_v12 = V1_SizeB >= s && a >= r;

            //... и во втором варианте
            bool isFitsInSizeA_v21 = V2_SizeА >= r && b >= s;
            bool isFitsInSizeB_v21 = V2_SizeB >= r && a >= s;
            // с поворотом на 90 градусов
            bool isFitsInSizeA_v22 = V2_SizeА >= s && b >= r;
            bool isFitsInSizeB_v22 = V2_SizeB >= s && a >= r;

            if (isFitsInSizeA_v11 || isFitsInSizeB_v11 || isFitsInSizeA_v12 || isFitsInSizeB_v12 ||
                isFitsInSizeA_v21 || isFitsInSizeB_v21 || isFitsInSizeA_v22 || isFitsInSizeB_v22)
            {
                Console.WriteLine("Оба дома успешно размещаются");
            }
            else
                Console.WriteLine("Дома разместить не удается");
            Console.ReadKey();
        }
    }
}
