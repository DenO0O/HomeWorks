using System;

namespace Task14_1
{
    internal class Program
    {

        delegate int Transformer(int x);

        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine($"Начальный массив: {string.Join(",", ints)}");

            int[] intDouble = Transform(ints, x => 2 * x);
            int[] int_pow2 = Transform(ints, x => x * x);
            int[] int_abs = Transform(ints, x => Math.Abs(x));

            Console.WriteLine($"Удвоенные значения: {string.Join(",", intDouble)}");
            Console.WriteLine($"Значение в степени 2: {string.Join(",", int_pow2)}");
            Console.WriteLine($"Модули чисел: {string.Join(",", int_abs)}");

            Console.ReadKey();
        }

        static int[] Transform(int[] ints, Transformer transformer)
        {
            int[] result = new int[ints.Length];
            for (int i = 0; i < ints.Length; i++)
                result[i] = transformer(ints[i]);
            return result;
        }
    }
}
