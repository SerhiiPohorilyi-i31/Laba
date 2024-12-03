using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда-вираз для перевірки, чи число ділиться на 5
        Predicate<int> isDivisibleByFive = number => number % 5 == 0;

        // Введення числа
        Console.Write("Введіть число: ");
        int input = int.Parse(Console.ReadLine());

        // Використання Predicate для перевірки
        bool result = isDivisibleByFive(input);

        // Виведення результату
        if (result)
        {
            Console.WriteLine($"Число {input} ділиться на 5.");
        }
        else
        {
            Console.WriteLine($"Число {input} не ділиться на 5.");
        }
    }
}
