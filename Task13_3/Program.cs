using System;

namespace Task13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "Игрок";
            Console.WriteLine("=== Игра 'Битва с монстром' ===");
            Console.WriteLine("Введите имя вашего персонажа:");
            Console.Write(">");
            playerName = Console.ReadLine();
            bool isGameRestart = true; //True - выбран запуск заново

            while (isGameRestart)
            {
                bool isContinue = true; //Будет false если пользователь прервет бой

                Player player = new Player(playerName, 20);
                Monster monster = new Monster();

                Console.WriteLine($"Битва начинается! {player.Name} против {monster.Name}!");

                while (isContinue && player.Health > 0 && monster.Health > 0)
                {
                    Console.WriteLine("Ваш ход (1  Атаковать / 2 - Использовать зелье здоровья / 0 - Закончить бой):");
                    switch (Console.ReadLine())
                    {
                        case "0": //Игра прервана игроком
                            isContinue = false;
                            break;
                        case "1": //Атакуем
                            Console.WriteLine(player.Attack(monster));
                            break;
                        case "2": //Лечимся
                            Console.WriteLine(player.UseHealthPotion());
                            break;
                        default:
                            continue;
                    }
                    if (!isContinue) break;

                    if (monster.Health > 0) //Монстр не будет атаковать, если уже умер
                    {
                        Console.WriteLine($"Ход {monster.Name}");
                        Console.WriteLine(monster.Attack(player));
                    }
                    Console.WriteLine($"Текущее состояние:\n\t{player.Name}: {player.Health} HP\n\t{monster.Name}: {monster.Health} HP");
                }

                if (isContinue == false)
                    Console.WriteLine("Бой прерван");
                else if (player.Health <= 0)
                    Console.WriteLine($"{player.Name} проиграл");
                else if (monster.Health <= 0)
                    Console.WriteLine($"{player.Name} выиграл");

                Console.WriteLine($"Сыграем снова? (1 - Да; Любой символ - Нет)");
                Console.Write(">");
                if (Console.ReadLine() != "1")
                    isGameRestart = false;
            }
        }
    }
}

abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public bool IsAlive { get; private set; } = true;

    public Character(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public virtual string Attack(Character target)
    {
        target.Health -= Damage;
        if (target.Health <= 0) IsAlive = false;
        return $"{Name} наносит {Damage} урона {target.Name}!";
    }
}

class Player : Character
{
    public int HealingPotion { get; set; } = 3;

    public Player(string name, int health) : base(name, health, 5) //урон фиксирован 5 единиц.
    { }

    public string UseHealthPotion()
    {
        if (HealingPotion > 0)
        {
            HealingPotion--;
            Health += 10;
        }
        return $"{Name} выпивает зелье здоровья!";
    }
}

class Monster : Character
{
    Random rnd = new Random();

    public Monster() : base("Злобный гоблин", 20, 0) //имя "Злобный Гоблин" и стартовое здоровье 20 HP
    { }

    public override string Attack(Character target)
    {
        //случайный урон (от 1 до 6) при каждой атаке
        Damage = rnd.Next(1, 7);
        return base.Attack(target);
    }
}