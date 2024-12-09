using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 42, 32, 25, 18, 27, 58, 78 };

        // 1. Знаходимо суму чисел
        int sum = numbers.Sum();

        // 2. Обчислюємо різницю чисел (42 - 32 - 25 - 18 - 27 - 58 - 78)
        int difference = numbers.Aggregate((total, next) => total - next);

        // Вивід результатів
        Console.WriteLine($"Сума чисел: {sum}");
        Console.WriteLine($"Різниця чисел: {difference}");
    }
}
