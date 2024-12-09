using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Колекція доменних імен
        List<string> domains = new List<string>
        {
            "google.com",
            "youtube.com",
            "rozetka.ua",
            "ukr.net",
            "olx.ua",
            "prom.ua",
            "tabletki.ua",
            "auto.ria.com"
        };

        // Запит LINQ для вибору сайтів, які закінчуються на ".ru" або ".ua"
        var selectedDomains = domains
            .Where(domain => domain.EndsWith(".ru") || domain.EndsWith(".ua"))
            .ToList();

        // Кількість відібраних сайтів
        int count = selectedDomains.Count;

        // Вивід результатів
        Console.WriteLine("Сайти, які закінчуються на '.ru' або '.ua':");
        foreach (var domain in selectedDomains)
        {
            Console.WriteLine(domain);
        }

        Console.WriteLine($"\nКількість таких сайтів: {count}");
    }
}

