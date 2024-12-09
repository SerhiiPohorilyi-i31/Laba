using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Задаємо генератор випадкових чисел для температур
        Random random = new Random();

        // Генеруємо масив із 30 значень температури для кожного дня місяця (-10 до 30 градусів)
        int[] temperatures = new int[30];
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = random.Next(-10, 31); // Випадкові значення від -10 до 30
        }

        // Виводимо згенеровані температури
        Console.WriteLine("Температури за місяць:");
        Console.WriteLine(string.Join(", ", temperatures));

        // LINQ-запит для вибору днів із температурою > 10
        var warmDays = temperatures
            .Select((temp, index) => new { Day = index + 1, Temp = temp }) // Додаємо номери днів
            .Where(day => day.Temp > 10); // Вибираємо дні з температурою > 10

        // Знаходимо найменшу температуру за місяць
        int minTemperature = temperatures.Min();

        // Виводимо результати
        Console.WriteLine("\nДні, коли температура була більше 10°С:");
        foreach (var day in warmDays)
        {
            Console.WriteLine($"День {day.Day}: {day.Temp}°C");
        }

        Console.WriteLine($"\nНайменша температура за місяць: {minTemperature}°C");
    }
}

