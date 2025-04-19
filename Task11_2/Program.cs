using System;

namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flayers = new IFlyable[] {
                new Bird(1200),
                new Airplane(2500, 120)
            };

            foreach (var f in flayers)
            {
                f.Fly();
            }
            Console.ReadKey();
        }

        interface IFlyable
        {
            void Fly();

            int MaxAltitude {  get; }
        }

        class Bird : IFlyable
        {
            int maxAltitude;

            public Bird(int MaxAltitude)
            {
                maxAltitude = MaxAltitude;
            }

            public int MaxAltitude => maxAltitude;

            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
            }
        }

        class Airplane : IFlyable
        {
            int maxAltitude;

            public Airplane(int MaxAltitude, int countPassengers)
            {
                maxAltitude = MaxAltitude;
                CountPassengers = countPassengers;
            }

            public int CountPassengers { get; set; }

            public int MaxAltitude => maxAltitude;

            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
            }
        }

    }
}
