using System;

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal[] { new Cat(), new Dog() };

            foreach (var animal in animals)
            {
                animal.ShowInfo();
            }
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        abstract public string Name { get; set; }

        abstract public string Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Say());
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; } = "Кошка";

        public override string Say()
        {
            return "Мяу!";
        }
    }

    class Dog : Animal
    {
        public override string Name { get; set; } = "Собака";

        public override string Say()
        {
            return "Гав!";
        }
    }
}
