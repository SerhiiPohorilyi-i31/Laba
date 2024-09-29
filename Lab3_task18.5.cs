using System;

class Box
{
    // Поля класу (довжина, ширина, висота)
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    // Конструктор з параметрами
    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    // Метод для обчислення об'єму коробки
    public double Volume()
    {
        return Length * Width * Height;
    }

    // Перевантаження оператора + (додавання розмірів двох коробок)
    public static Box operator +(Box b1, Box b2)
    {
        return new Box(b1.Length + b2.Length, b1.Width + b2.Width, b1.Height + b2.Height);
    }

    // Перевантаження оператора - (віднімання розмірів двох коробок)
    public static Box operator -(Box b1, Box b2)
    {
        return new Box(b1.Length - b2.Length, b1.Width - b2.Width, b1.Height - b2.Height);
    }

    // Перевантаження оператора == (перевірка на рівність за розмірами)
    public static bool operator ==(Box b1, Box b2)
    {
        return (b1.Length == b2.Length && b1.Width == b2.Width && b1.Height == b2.Height);
    }

    // Перевантаження оператора != (перевірка на нерівність за розмірами)
    public static bool operator !=(Box b1, Box b2)
    {
        return !(b1 == b2);
    }

    // Перевантаження оператора > (порівняння об'єму двох коробок)
    public static bool operator >(Box b1, Box b2)
    {
        return b1.Volume() > b2.Volume();
    }

    // Перевантаження оператора < (порівняння об'єму двох коробок)
    public static bool operator <(Box b1, Box b2)
    {
        return b1.Volume() < b2.Volume();
    }

    // Метод для виведення інформації про коробку
    public override string ToString()
    {
        return $"Довжина: {Length}, Ширина: {Width}, Висота: {Height}";
    }

    // Обов'язково перевизначаємо Equals та GetHashCode при перевантаженні == та !=
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        Box box = (Box)obj;
        return (Length == box.Length && Width == box.Width && Height == box.Height);
    }

    public override int GetHashCode()
    {
        return Tuple.Create(Length, Width, Height).GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        // Створення двох об'єктів класу Box
        Box box1 = new Box(10, 15, 20);
        Box box2 = new Box(5, 10, 15);

        Console.WriteLine("Початкові розміри коробок:");
        Console.WriteLine($"Box 1: {box1}");
        Console.WriteLine($"Box 2: {box2}");

        // Додавання розмірів коробок
        Box box3 = box1 + box2;
        Console.WriteLine($"\nПісля додавання Box 1 + Box 2 = {box3}");

        // Віднімання розмірів коробок
        Box box4 = box1 - box2;
        Console.WriteLine($"Після віднімання Box 1 - Box 2 = {box4}");

        // Перевірка на рівність
        Console.WriteLine($"\nBox 1 == Box 2: {box1 == box2}");
        Console.WriteLine($"Box 1 != Box 2: {box1 != box2}");

        // Порівняння за об'ємом
        Console.WriteLine($"\nОб'єм Box 1: {box1.Volume()}");
        Console.WriteLine($"Об'єм Box 2: {box2.Volume()}");
        Console.WriteLine($"Box 1 > Box 2: {box1 > box2}");
        Console.WriteLine($"Box 1 < Box 2: {box1 < box2}");

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}

