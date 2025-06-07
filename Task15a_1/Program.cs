using System;
using System.Collections.Generic;
using System.Linq;

namespace Task15a_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Определить:
                -все компьютеры с указанным процессором. Название процессора запросить у пользователя;
                -все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;
                -вывести весь список, отсортированный по увеличению стоимости;
                -вывести весь список, сгруппированный по типу процессора;
                -найти самый дорогой и самый бюджетный компьютер;
                -есть ли хотя бы один компьютер в количестве не менее 30 штук ?
            */

            var comps = new List<ComputerData>() {
                new ComputerData { Code = "A001-1", Mark = "Comp1A", CPUType = "CPUType1", CPUMhz = 3500, MemoryVolumeGb = 16, HDDVolumeMb = 500, VideoMemoryVolume = 8, Cost = 5000, Quantity = 9 },
                new ComputerData { Code = "A001-2", Mark = "Comp1B", CPUType = "CPUType1", CPUMhz = 3500, MemoryVolumeGb = 32, HDDVolumeMb = 1000, VideoMemoryVolume = 16, Cost = 9000, Quantity = 6 },
                new ComputerData { Code = "A001-3", Mark = "Comp1C", CPUType = "CPUType2", CPUMhz = 3900, MemoryVolumeGb = 32, HDDVolumeMb = 1000, VideoMemoryVolume = 16, Cost = 12000, Quantity = 12 },
                new ComputerData { Code = "B001-1", Mark = "Comp2A", CPUType = "CPUType3", CPUMhz = 2500, MemoryVolumeGb = 16, HDDVolumeMb = 500, VideoMemoryVolume = 8, Cost = 8000, Quantity = 37 },
                new ComputerData { Code = "B001-2", Mark = "Comp2B", CPUType = "CPUType3", CPUMhz = 2500, MemoryVolumeGb = 32, HDDVolumeMb = 1000, VideoMemoryVolume = 12, Cost = 14000, Quantity = 25 },
                new ComputerData { Code = "B001-3", Mark = "Comp2C", CPUType = "CPUType4", CPUMhz = 1500, MemoryVolumeGb = 16, HDDVolumeMb = 500, VideoMemoryVolume = 6, Cost = 6500, Quantity = 40 },
                new ComputerData { Code = "C001-1", Mark = "Comp3A", CPUType = "CPUType1", CPUMhz = 3500, MemoryVolumeGb = 32, HDDVolumeMb = 1000, VideoMemoryVolume = 16, Cost = 18000, Quantity = 12 },
                new ComputerData { Code = "C001-2", Mark = "Comp3B", CPUType = "CPUType1", CPUMhz = 3500, MemoryVolumeGb = 64, HDDVolumeMb = 2000, VideoMemoryVolume = 32, Cost = 24000, Quantity = 10 },
                new ComputerData { Code = "C001-3", Mark = "Comp3C", CPUType = "CPUType2", CPUMhz = 3900, MemoryVolumeGb = 64, HDDVolumeMb = 2000, VideoMemoryVolume = 32, Cost = 29000, Quantity = 8 }
            };

            var orderedCompList = comps.OrderBy(x => x.Cost);

            Console.WriteLine("Введите название нужного процессора:");
            Console.WriteLine("Доступны:");
            ShowList(comps.Select(cpu => cpu.CPUType).Distinct());
            Console.Write(">");
            var userCPUType = Console.ReadLine();

            Console.WriteLine($"В наличии с процессором {userCPUType}:");
            ShowList(comps.Where(comp => comp.CPUType == userCPUType));

            Console.WriteLine("Введите нужный объем памяти:");
            var memoryVolumes = comps.Select(mem => mem.MemoryVolumeGb).Distinct();
            int userMemVolume = 0;
            while (userMemVolume == 0)
                try
                {
                    Console.WriteLine("Доступны конфигурации с:");
                    ShowList(memoryVolumes);
                    Console.Write(">");
                    userMemVolume = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверый ввод:");
                }

            Console.WriteLine("В наличии:");
            ShowList(comps.Where(comp => comp.MemoryVolumeGb >= userMemVolume));

            Console.WriteLine("Весь список по стоимости");
            ShowList(orderedCompList);

            Console.WriteLine("Весь список по типу процессора");
            ShowList(comps.GroupBy(x => x.CPUType));

            Console.WriteLine("Самый дорогой:");
            ShowList(orderedCompList.LastOrDefault());

            Console.WriteLine("Самый дешевый:");
            ShowList(orderedCompList.FirstOrDefault());

            Console.WriteLine("Конфигурации с количеством более 30 шт:");
            if (comps.Any(x => x.Quantity > 30))
                Console.WriteLine("есть");
            else
                Console.WriteLine("нету");

            Console.ReadKey();
        }

        static void ShowList<T>(IEnumerable<T> ListToShow)
        {
            if (ListToShow == null || ListToShow.Count() == 0) return;

            foreach (var item in ListToShow)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void ShowList(IEnumerable<ComputerData> ListToShow)
        {
            if (ListToShow == null || ListToShow.Count() == 0) return;
            ShowTableTitle();

            foreach (var item in ListToShow)
                Console.WriteLine(item);

            Console.WriteLine();
        }

        static void ShowList(ComputerData data)
        {
            if (data == null) return;
            ShowList(new List<ComputerData>() { data });
        }

        static void ShowList(IEnumerable<IGrouping<string, ComputerData>> ListToShow)
        {
            if (ListToShow == null || ListToShow.Count() == 0) return;
            ShowTableTitle();
            foreach (var group in ListToShow)
            {
                Console.WriteLine(group.Key);
                foreach (var comp in group)
                    Console.WriteLine(comp);
            }
            Console.WriteLine();
        }

        static void ShowTableTitle()
        {
            Console.WriteLine($"{"Код",8} {"Марка",8} {"Проц",8} {"Mhz",10} {"Память",6} {"Диск",6} {"Видео",6} {"Цена",8} {"шт.",6}");
        }

        class ComputerData
        {
            public string Code { get; set; }

            public string Mark { get; set; }

            public string CPUType { get; set; }

            public int CPUMhz { get; set; }

            public int MemoryVolumeGb { get; set; }

            public int HDDVolumeMb { get; set; }

            public int VideoMemoryVolume { get; set; }

            public double Cost { get; set; }

            public int Quantity { get; set; }

            public override string ToString()
            {
                return $"{Code,8} {Mark,8} {CPUType,8} {CPUMhz,10} {MemoryVolumeGb,6} {HDDVolumeMb,6} {VideoMemoryVolume,6} {Cost,8} {Quantity,6}";
            }
        }
    }
}
