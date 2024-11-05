using System;
using System.Collections.Generic;

// Клас журналів
public class Magazine
{
    public string Name { get; set; }
    public int Pages { get; set; }
    public int SalesRating { get; set; } // рейтинг продажів від 1 до 10

    public Magazine(string name, int pages, int salesRating)
    {
        Name = name;
        Pages = pages;
        SalesRating = salesRating;
    }
}

// Клас порівняння журналів
public class MagazineComparer : IComparer<Magazine>
{
    private ComparisonType comparisonType;

    // Конструктор, що приймає тип порівняння
    public MagazineComparer(ComparisonType comparisonType)
    {
        this.comparisonType = comparisonType;
    }

    public enum ComparisonType
    {
        ByPages,
        BySalesRating
    }

    // Метод порівняння
    public int Compare(Magazine x, Magazine y)
    {
        if (x == null || y == null)
        {
            throw new ArgumentException("Один або обидва об'єкти для порівняння є null.");
        }

        switch (comparisonType)
        {
            case ComparisonType.ByPages:
                return x.Pages.CompareTo(y.Pages);
            case ComparisonType.BySalesRating:
                return x.SalesRating.CompareTo(y.SalesRating);
            default:
                throw new ArgumentException("Неправильний тип порівняння");
        }
    }
}

// Головний клас програми
public class Program
{
    public static void Main()
    {
        // Створення списку журналів
        List<Magazine> magazines = new List<Magazine>
        {
            new Magazine("Forbes", 100, 8),
            new Magazine("Vogue", 80, 6),
            new Magazine("Burda", 120, 9),
            new Magazine("Локальна історія", 90, 7)
        };

        // Порівняння за кількістю сторінок
        magazines.Sort(new MagazineComparer(MagazineComparer.ComparisonType.ByPages));
        Console.WriteLine("Сортування за кількістю сторінок:");
        foreach (var magazine in magazines)
        {
            Console.WriteLine($"{magazine.Name} - Кількість сторінок: {magazine.Pages}, Рейтинг продажів: {magazine.SalesRating}");
        }

        // Порівняння за рейтингом продажів
        magazines.Sort(new MagazineComparer(MagazineComparer.ComparisonType.BySalesRating));
        Console.WriteLine("\nСортування за рейтингом продажів:");
        foreach (var magazine in magazines)
        {
            Console.WriteLine($"{magazine.Name} - Кількість сторінок: {magazine.Pages}, Рейтинг продажів: {magazine.SalesRating}");
        }
    }
}

