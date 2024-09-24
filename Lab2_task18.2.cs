public abstract class Plant
{
    public string Name { get; set; } // Назва рослини
    public double Height { get; set; } // Висота рослини

    // Конструктор з параметрами
    public Plant(string name, double height)
    {
        Name = name;
        Height = height;
    }

    // Абстрактні методи без реалізації
    public abstract void DisplayInfo();
    public abstract void Describe();
}

public class Tree : Plant
{
    public string Species { get; set; } // Порода дерева
    public int Age { get; set; } // Вік дерева

    // Конструктор з параметрами, викликає базовий конструктор
    public Tree(string name, double height, string species, int age)
        : base(name, height)
    {
        Species = species;
        Age = age;
    }

    // Реалізація абстрактного методу DisplayInfo
    public override void DisplayInfo()
    {
        Console.WriteLine($"Дерево: {Name}, висота: {Height}, порода: {Species}, вік: {Age}");
    }

    // Реалізація абстрактного методу Describe
    public override void Describe()
    {
        Console.WriteLine("Це дерево, яке має свої особливості.");
    }

    // Метод для перевірки віку дерева
    public void CheckTree(string species, int age)
    {
        if (species == Species && age == Age)
        {
            Console.WriteLine($"Дерево знайдено! Назва: {Name}, Порода: {Species}, Висота: {Height}, Вік: {Age}");
        }
        else
        {
            Console.WriteLine($"Такого дерева у нас немає: {species}, {age} років.");
        }
    }

    // Метод для виведення назви, породи та віку
    public void DisplayTree()
    {
        Console.WriteLine($"Назва: {Name}, Порода: {Species}, Вік: {Age}");
    }
}

public class Flower : Plant
{
    public string Color { get; set; } // Колір квітки

    // Конструктор з параметрами, викликає базовий конструктор
    public Flower(string name, double height, string color)
        : base(name, height)
    {
        Color = color;
    }

    // Реалізація абстрактного методу DisplayInfo
    public override void DisplayInfo()
    {
        Console.WriteLine($"Квітка: {Name}, висота: {Height}, колір: {Color}");
    }

    // Реалізація абстрактного методу Describe
    public override void Describe()
    {
        Console.WriteLine("Це квітка, яка має гарний колір.");
    }

    // Метод для виведення інформації про троянду
    public void RoseInfo()
    {
        Console.WriteLine("Яка це троянда?");
        Console.WriteLine("Це троянда Блек Меджік. Вона майже чорного кольору.");
    }
}

class Program
{
    static void Main()
    {
        // Створюємо об'єкт класу Tree
        Tree tree = new Tree("Груша", 5.5, "Груша", 15);

        // Викликаємо методи класу Tree
        tree.DisplayInfo();
        tree.Describe();
        tree.CheckTree("Яблуня", 10);
        tree.CheckTree("Груша", 15);
        tree.DisplayTree();

        // Створюємо об'єкт класу Flower
        Flower rose = new Flower("Троянда", 0.7, "Чорний");

        // Викликаємо методи класу Flower
        rose.DisplayInfo();
        rose.Describe();
        rose.RoseInfo();
    }
}


