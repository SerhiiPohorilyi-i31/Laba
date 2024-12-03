using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда-вираз для перевірки, чи можуть три сторони утворити трикутник
        Func<double, double, double, bool> isTriangle = (a, b, c) =>
            a + b > c && a + c > b && b + c > a;

        // Введення довжин сторін
        Console.Write("Введіть довжину сторони a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони c: ");
        double c = double.Parse(Console.ReadLine());

        // Використання лямбда-виразу для перевірки
        bool result = isTriangle(a, b, c);

        // Виведення результату
        if (result)
        {
            Console.WriteLine("Ці сторони можуть утворити трикутник.");
        }
        else
        {
            Console.WriteLine("Ці сторони не можуть утворити трикутник.");
        }
    }
}
