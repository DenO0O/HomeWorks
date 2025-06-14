using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи продолжения:");
            Task<int[]> task_CreateArr = Task.Run(() => GenerateArrayTask(9));
            Task<double> task_averageVal = task_CreateArr.ContinueWith(t => CalculateAverage(task_CreateArr.Result));
            Console.WriteLine($"Cреднее арифметическое: {task_averageVal.Result}");

            Console.WriteLine("Асинхронно:");
            int[] result = GenerateArrayTaskAsync().Result;
            double average = CalculateAverageAsync(result).Result;
            Console.WriteLine($"Cреднее арифметическое: {average}");

            Console.ReadKey();
        }

        static int[] GenerateArrayTask(int size)
        {
            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
            }
            Thread.Sleep(1000);
            return array;
        }

        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            Thread.Sleep(50);
            return (double)sum / array.Length;
        }

        static async Task<int[]> GenerateArrayTaskAsync()
        {
            return await Task.Run(() => GenerateArrayTask(12));
        }

        static async Task<double> CalculateAverageAsync(int[] array)
        {
            return await Task.Run(() => CalculateAverage(array));
        }
    }
}
