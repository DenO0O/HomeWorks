using System;

namespace Task9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте класс BankAccount, который моделирует банковский счет:
            //    Поля:
            //        _balance(текущий баланс, private)
            //Статическое поле:
            //    TotalAccounts(общее количество созданных счетов)
            //Свойства:
            //    AccountNumber(номер счета, readonly)
            //    Balance(public геттер, private сеттер)
            //Конструктор:
            //    Увеличивает TotalAccounts и генерирует AccountNumber(например, случайный 4-значный номер).
            //Методы:
            //    Deposit(decimal amount) – пополняет баланс.
            //    Withdraw(decimal amount) – снимает деньги(если хватает средств, иначе выбрасывает исключение).

            var ba = new BankAccount();
        }
    }

    class BankAccount
    {
        decimal _balance = 0;
        static int totalAccounts = 0;

        public int AccountNumber { get; }

        public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public BankAccount()
        {
            totalAccounts++;
            AccountNumber = GetAccountNumber();
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (_balance < amount)
                throw new Exception("На счете недостаточно средств.");
            else
                _balance -= amount;
        }

        static int GetAccountNumber()
        {
            Random random = new Random();
            return random.Next(1, 10000);
        }
    }
}
