using System;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объектов обоих типов
            var bilding = new Building("Город, улица, дом", 5500, 1990);
            var mbuilding = new MultiBuilding("Москва, Ленина, 1", 9500, 2000, 3, true);
            bilding.DisplayInfo();
            Console.WriteLine();

            //Upcasting (приведение производного класса к базовому)
            Building building1 = mbuilding;

            //Downcasting (обратное приведение с проверкой типа)
            MultiBuilding multiBuilding = building1 as MultiBuilding;

            //Вызов переопределенных методов
            if (multiBuilding != null)
            {
                var tax2 = multiBuilding.CalculateTax();
                multiBuilding.DisplayInfo(); // Использование уникальных методов производного класса (внутри)
            }

            Console.ReadKey();
        }
    }

    class Building
    {
        string _address; //адрес здания
        double _area; //площадь в квадратных метрах
        int _yearBuilt; //год постройки

        public int BuildingAge { get; private set; }

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
            BuildingAge = DateTime.Now.Year - yearBuilt;
        }

        public virtual double CalculateTax()
        {
            return _area * 1000;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Адрес: {_address}\nПлощадь: {_area} м2\nГод строительства: {_yearBuilt} (Возраст: {BuildingAge})\nНалог: {CalculateTax():f2}");
        }
    }

    sealed class MultiBuilding : Building
    {
        int _floors; //количество этажей
        bool _hasElevator; //наличие лифта
        const double elevatorTax = 5000; //налог за лифт

        public double AreaPerFloor { get; set; }

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors; //кол-во этажей
            _hasElevator = hasElevator; //наличие лифта
            AreaPerFloor = area / floors;
        }

        public override double CalculateTax()
        {
            return base.CalculateTax() * (1 + (_floors - 1) * 0.05) + (_hasElevator ? elevatorTax : 0);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Этажность: {_floors} ({AreaPerFloor:f2} м2 на этаж)\nНаличие лифта: {(_hasElevator ? "Да" : "Нет")}");
        }
    }
}
