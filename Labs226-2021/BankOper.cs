﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOper
{
    class BankOper
    {
        static void Main(string[] args)
        {

            Employee account1 = new Employee("Ivan", 0, 1971);
            BankAccount account2 = new BankAccount("Kirill", 3000, 1984);
            BankAccount account3 = new BankAccount("Elena", 6000, 2001);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            BankAccount.rate = 0.01;
            BankAccount.GetProfit(account1, 10);
            BankAccount.GetProfit(account2, 10);
            BankAccount.GetProfit(account3, 10);
            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            BankAccount.Withdraw(account1, 200);
            BankAccount.Transaction(account1, account2);
            account1.ShowInfo();
            account2.ShowInfo();
        }
    }
    class Employee : BankAccount
    {
        public Employee(string name, double balance, int YearOfBirth) : base(name, balance, YearOfBirth)
        {

        }
        public override void Deposit (Client acc, double money)
        {
            if (money < maxDeposit & money > minDeposit)
            {
                acc.balance += money;
                Console.WriteLine($"{name} положил на счёт пользлвателя {acc.name} деньги");
                acc.ShowInfo();
            }
            else 
            {
                Console.WriteLine($"Достигнут лимит депозита составляющий минимум {minDeposit} и максимум {maxDeposit}");
            }
        }


    }

    class Client : BankAccount 
    {
        public Client(string name, double balance, int YearOfBirth) : base(name, balance, YearOfBirth)
        {

        }
        public override void Deposit (Client acc, double money)
        {
            if (Age > 0)
            {
                if (money < maxDeposit & money > minDeposit)
                {
                    Console.WriteLine($"Клиент {name} пришёл пополнить счёт в Банк");
                    balance += money;
                    Console.WriteLine($"Счёт пополнен на {money}");
                    ShowInfo();

                }
                else
                {
                    Console.WriteLine($"Достигнут лимит депозита составляющий минимум {minDeposit} и максимум {maxDeposit}");
                }
            }
            else
            {
                Console.WriteLine("Нет права доступа");
            }
        }

    }

    class BankAccount
    {
        public string name;
        public double balance;
        private int _yearofBirth;
        public static double rate = 0.007;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double maxDeposit = 50000;
        public static double comissionForTransaction = 0.02;
        


        public BankAccount(string name, double balance, int YearOfBirth)
        {
            this.name = name;
            this.balance = balance;
            this.Age = YearOfBirth;
        }
        public int Age
        {
            get
            {
                return _yearofBirth;
            }

            set
            {
                if (value > 1900 & value <= DateTime.Now.Year & DateTime.Now.Year - value >= 18)
                    _yearofBirth = DateTime.Now.Year - value;
                else
                {
                    Console.WriteLine("Введён неверный год" + " " + $" { name}");
                }
            }
        }
        public void ShowInfo()
        {
            if (Age > 18)
                System.Console.WriteLine($"{name} - {balance} - {Age}");
            else
            {
                Console.WriteLine("Ваш возраст не соответсвует требованиям");
            }
        }

        public static void GetProfit(BankAccount acc, int month)
        {
            {

                if (acc.Age > 0)
                {
                    for (int i = 0; i < month; i++)
                    {
                        acc.balance += acc.balance * rate;
                    }
                }
                else
                {
                    Console.WriteLine("Ваш возраст не соответсвет требованиям");
                }

            }
        }

        public void Deposit(BankAccount acc, double money)
        {
            if (Age > 0)
            {
                if (money < minDeposit)
                {
                    Console.WriteLine("Слишком маленькая сумма, минимальный депозит составляет 10");
                }
                else
                {
                    acc.balance = acc.balance + money;
                    Console.WriteLine($"На баланс {acc.name} было зачисленно {money}, теперь его баланс составляет {acc.balance}");
                }
            }
            else
            {
                Console.WriteLine("Ваш возраст слишком мал");
            }

        }

        public static void Withdraw(BankAccount acc, double money)
        {
            if (money < minWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет снять, слишком мала, он может снять минимум {minWidtraw} ");
            }
            else if (money > maxWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет снять, слишком велика, за раз он может снять максимум {maxWidtraw} ");
            }
            else
            {
                acc.balance = acc.balance - money;
                Console.WriteLine($"{acc.name} снял {money} и на его счету осталось {acc.balance}");
            }

        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter)
        {
            if (accSeller.Age > 0 & accGetter.Age > 0)
            {
                Console.WriteLine($"Введите сумму перевода");
                double p = double.Parse(Console.ReadLine());
                if (p < 0)
                {
                    Console.WriteLine("Недопустимое зачение");
                }
                else
                {
                    double k = (p * comissionForTransaction) + p;
                    if (k > accSeller.balance)
                    {
                        Console.WriteLine("На вашем счете недостаточно средств");
                    }
                    else
                    {
                        Console.WriteLine($"{accSeller.name}, Вы хотите совершить перевод {accGetter.name}?");
                        string o = Console.ReadLine();
                        if (o == "да")
                        {

                            accGetter.balance = accGetter.balance + p;
                            Console.WriteLine($"С учётом коммисии с вашего счета вычлось {k}");
                            accSeller.balance = accSeller.balance - k;
                            Console.ReadKey();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ваш возраст слишком мал");
            }
        }
    }
}