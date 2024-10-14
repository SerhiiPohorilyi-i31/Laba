// BankAccount.cs
public abstract class BankAccount : IAccountManagement
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Реалізація методів інтерфейсу
    public void Новий_рахунок()
    {
        Console.WriteLine($"Новий рахунок створено: {AccountNumber} з початковим балансом {Balance} грн.");
    }

    public void Видалити_рахунок()
    {
        Console.WriteLine($"Рахунок {AccountNumber} видалено.");
    }

    // Абстрактні методи для поповнення та зняття коштів
    public abstract void Поповнити_рахунок(double amount);
    public abstract void Зняти_з_рахунку(double amount);
}