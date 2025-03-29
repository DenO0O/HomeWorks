using System;

namespace Task8_2
{
    class Program
    {
        static void Main(string[] args)
        { //Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
            //    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
            //    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").
            try
            {
                Console.WriteLine("Возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static void ValidateAge(int age)
        {
            if (age < 0) throw new ArgumentException("Возраст не может быть отрицательным");
            if (age > 150) throw new ArgumentOutOfRangeException("Слишком большой возраст");
        }
    }
}
