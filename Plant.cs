using System;

class Plant
{
    // Приватні поля
    private string name;
    private string variety;
    private double price;
    private double height;

    // Властивості для доступу до полів
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Variety
    {
        get { return variety; }
        set { variety = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0) // Вартість не може бути негативною
                price = value;
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            if (value >= 0) // Висота не може бути негативною
                height = value;
        }
    }

    // Конструктор без параметрів
    public Plant()
    {
        // Ініціалізація значень через властивості
        Name = "Невідома рослина";
        Variety = "Невідомий сорт";
        Price = 0.0;
        Height = 0.0;
    }

    // Метод для зміни сорту та ціни
    public void UpdateVarietyAndPrice(string newVariety, double newPrice)
    {
        Variety = newVariety;
        Price = newPrice;
        Console.WriteLine($"Новий сорт: {Variety}, Нова ціна: {Price} грн");
    }

    // Метод для аналізу висоти рослини
    public void AnalyzeHeight()
    {
        if (height < 50)
            Console.WriteLine($"Невелика рослина. Її висота = {height} см");
        else if (height > 150)
            Console.WriteLine($"Висока рослина. Її висота = {height} см");
        else
            Console.WriteLine($"Середня рослина. Її висота = {height} см");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Plant
        Plant rose = new Plant();

        // Ініціалізація полів через властивості
        rose.Name = "Троянда";
        rose.Variety = "БлекМеджік";
        rose.Price = 50;
        rose.Height = 80;

        // Виведення інформації про рослину
        Console.WriteLine($"Назва: {rose.Name}");
        Console.WriteLine($"Сорт: {rose.Variety}");
        Console.WriteLine($"Вартість: {rose.Price} грн");
        Console.WriteLine($"Висота: {rose.Height} см");

        // Зміна сорту та ціни
        rose.UpdateVarietyAndPrice("Черрі Бренді", 115);

        // Аналіз висоти
        rose.AnalyzeHeight();
    }
}



