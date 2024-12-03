using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Задати назви міст
        string[] cities = { "Київ", "Одеса", "Черкаси" };

        // Блоковий лямбда-вираз для визначення найдовшої та найкоротшої назви
        Action<string[]> findLongestAndShortest = cityNames =>
        {
            // Знаходження найдовшої назви
            string longest = cityNames.OrderByDescending(name => name.Length).First();
            // Знаходження найкоротшої назви
            string shortest = cityNames.OrderBy(name => name.Length).First();

            // Виведення результатів
            Console.WriteLine($"Найдовше місто: {longest} ({longest.Length} символів)");
            Console.WriteLine($"Найкоротше місто: {shortest} ({shortest.Length} символів)");
        };

        // Виклик лямбда-виразу
        findLongestAndShortest(cities);
    }
}

