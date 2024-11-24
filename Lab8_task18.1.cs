using System;

namespace Practical8_Task18_1
{
    class Program
    {
        // Делегат для обчислення значення функції
        delegate double Function(double x);

        static void Main(string[] args)
        {
            Console.Write("Введіть значення x: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                // Ініціалізація делегату відповідною функцією
                Function func = x > 0 ? FunctionForPositiveX : FunctionForNonPositiveX;

                // Виклик делегату та виведення результату
                double result = func(x);
                Console.WriteLine($"Результат обчислення F({x}) = {result:F2}");
            }
            else
            {
                Console.WriteLine("Помилка: введено некоректне значення.");
            }

            Console.ReadKey();
        }

        // Функція для x > 0: F(x) = sin²x + 1
        static double FunctionForPositiveX(double x)
        {
            return Math.Pow(Math.Sin(x), 2) + 1;
        }

        // Функція для x <= 0: F(x) = 1 - 2*sinx
        static double FunctionForNonPositiveX(double x)
        {
            return 1 - 2 * Math.Sin(x);
        }
    }
}


