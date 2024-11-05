using System;

public class Рослина : IComparable<Рослина>
{
    public string Назва { get; set; }
    public decimal Ціна { get; set; }

    public Рослина(string назва, decimal ціна)
    {
        Назва = назва;
        Ціна = ціна;
    }

    // Реалізація інтерфейсу IComparable для порівняння за ціною
    public int CompareTo(Рослина іншаРослина)
    {
        if (іншаРослина == null) return 1;
        return Ціна.CompareTo(іншаРослина.Ціна);
    }

    public override string ToString()
    {
        return $"{Назва}: {Ціна} грн";
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Створення масиву об'єктів класу Рослина
        Рослина[] рослини = {
            new Рослина("Троянда", 75.0m),
            new Рослина("Волошка", 40.0m),
            new Рослина("Тюльпан", 100.0m),
            new Рослина("Ромашка", 30.0m)
        };

        // Сортування масиву за ціною за допомогою CompareTo
        Array.Sort(рослини);

        Console.WriteLine("Список рослин, відсортований за ціною:");
        foreach (var рослина in рослини)
        {
            Console.WriteLine(рослина);
        }
    }
}


