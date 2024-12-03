using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда для обчислення F(x) = sin(2x) + 1 для x > 0
        Func<double, double> positiveFunction = x => Math.Sin(2 * x) + 1;

        // Лямбда для обчислення F(x) = 1 - 2 * sin(x) для x <= 0
        Func<double, double> nonPositiveFunction = x => 1 - 2 * Math.Sin(x);

        // Введення значення x
        Console.Write("Введіть значення x: ");
        double x = double.Parse(Console.ReadLine());

        // Визначення, яку функцію викликати
        double result = x > 0 ? positiveFunction(x) : nonPositiveFunction(x);

        // Виведення результату
        Console.WriteLine($"Результат F({x}) = {result}");
    }
}
