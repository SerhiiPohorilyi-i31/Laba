// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення екземпляра поточного рахунку
        CurrentAccount currentAccount = new CurrentAccount("CA123456789", 1000.0);
        currentAccount.Новий_рахунок();
        currentAccount.Поповнити_рахунок(500);
        currentAccount.Зняти_з_рахунку(300);
        currentAccount.Видалити_рахунок();

        Console.WriteLine();

        // Створення екземпляра депозитного рахунку
        DepositAccount depositAccount = new DepositAccount("DA987654321", 5000.0);
        depositAccount.Новий_рахунок();
        depositAccount.Поповнити_рахунок(1000);
        depositAccount.Зняти_з_рахунку(2000);
        depositAccount.Видалити_рахунок();

        Console.ReadKey();
    }
}