using System;
using System.Collections.Generic;
using System.Linq;

class Auto
{
    public string Model { get; set; }
    public decimal Price { get; set; }
    public int Year { get; set; }
    public string MadeIn { get; set; }

    public override string ToString()
    {
        return $"Model: {Model}, Price: {Price}, Year: {Year}, MadeIn: {MadeIn}";
    }
}

class Program
{
    static void Main()
    {
        // Створення колекції з 10 об'єктів класу Auto
        List<Auto> autos = new List<Auto>
        {
            new Auto { Model = "ModelA", Price = 14000, Year = 2015, MadeIn = "Франція" },
            new Auto { Model = "ModelB", Price = 16000, Year = 2016, MadeIn = "Корея" },
            new Auto { Model = "ModelC", Price = 13000, Year = 2011, MadeIn = "Франція" },
            new Auto { Model = "ModelD", Price = 20000, Year = 2020, MadeIn = "Німеччина" },
            new Auto { Model = "ModelE", Price = 10000, Year = 2010, MadeIn = "Корея" },
            new Auto { Model = "ModelF", Price = 15000, Year = 2013, MadeIn = "Корея" },
            new Auto { Model = "ModelG", Price = 17000, Year = 2012, MadeIn = "Японія" },
            new Auto { Model = "ModelH", Price = 9000, Year = 2005, MadeIn = "Корея" },
            new Auto { Model = "ModelI", Price = 8000, Year = 2019, MadeIn = "Німеччина" },
            new Auto { Model = "ModelJ", Price = 14500, Year = 2021, MadeIn = "Корея" }
        };

        // Запит LINQ для відбору екземплярів за критерієм ціна-якість
        var selectedAutos = autos
            .Where(a => a.Price <= 15000 && a.Year > 2010 && a.MadeIn == "Корея")
            .OrderBy(a => a.Model);

        Console.WriteLine("Автомобілі, що відповідають критерію ціна-якість:");
        foreach (var auto in selectedAutos)
        {
            Console.WriteLine(auto);
        }

        // Знаходження самого старого авто
        var oldestAuto = autos.OrderBy(a => a.Year).FirstOrDefault();

        Console.WriteLine("\nНайстаріший автомобіль:");
        Console.WriteLine(oldestAuto != null ? oldestAuto.ToString() : "Автомобілів немає.");
    }
}


