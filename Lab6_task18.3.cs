using System;
using System.Collections;
using System.Collections.Generic;

public class Рослина : IComparable<Рослина>
{
    public string Назва { get; set; }
    public decimal Ціна { get; set; }

    public Рослина(string назва, decimal ціна)
    {
        Назва = назва;
        Ціна = ціна;
    }

    // Метод CompareTo для порівняння за ціною
    public int CompareTo(Рослина інша)
    {
        return Ціна.CompareTo(інша.Ціна);
    }

    public override string ToString()
    {
        return $"{Назва} - Ціна: {Ціна} грн";
    }
}

public class КолекціяРослин : IEnumerable<Рослина>
{
    private List<Рослина> рослини = new List<Рослина>();

    public void ДодатиРослину(Рослина рослина)
    {
        рослини.Add(рослина);
    }

    public IEnumerator<Рослина> GetEnumerator()
    {
        return рослини.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Метод для впорядкування рослин за ціною
    public void СортуватиЗаЦіною()
    {
        рослини.Sort();
    }
}

class Program
{
    static void Main()
    {
        КолекціяРослин колекція = new КолекціяРослин();

        // Додаємо кілька рослин до колекції
        колекція.ДодатиРослину(new Рослина("Троянда", 25.50m));
        колекція.ДодатиРослину(new Рослина("Волошка", 15.75m));
        колекція.ДодатиРослину(new Рослина("Тюльпан", 35.00m));

        // Сортуємо за ціною
        колекція.СортуватиЗаЦіною();

        Console.WriteLine("Список рослин, впорядкований за ціною:");
        foreach (var рослина in колекція)
        {
            Console.WriteLine(рослина);
        }
    }
}


