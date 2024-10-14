// DepositAccount.cs
public class DepositAccount : BankAccount
{
    public DepositAccount(string accountNumber, double initialBalance)
        : base(accountNumber, initialBalance) { }

    // Реалізація методу поповнення рахунку
    public override void Поповнити_рахунок(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Поповнено депозитний рахунок {AccountNumber} на {amount} грн. Новий баланс: {Balance} грн.");
    }

    // Реалізація методу зняття коштів з рахунку
    public override void Зняти_з_рахунку(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Знято {amount} грн з депозитного рахунку {AccountNumber}. Новий баланс: {Balance} грн.");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів для зняття.");
        }
    }
}