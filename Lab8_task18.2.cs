using System;

namespace Practical8_Task18_2
{
    class Program
    {
        // Делегат для виведення інформації про колір
        delegate void ColorInfo();

        static void Main(string[] args)
        {
            Console.Write("Введіть номер кольору у спектрі (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int colorNumber) && colorNumber >= 1 && colorNumber <= 7)
            {
                ColorInfo colorDelegate = colorNumber switch
                {
                    1 => Red,
                    2 => Orange,
                    3 => Yellow,
                    4 => Green,
                    5 => Cyan,
                    6 => Blue,
                    7 => Violet,
                    _ => null
                };

                // Виклик делегату
                colorDelegate?.Invoke();
            }
            else
            {
                Console.WriteLine("Помилка: введено некоректний номер кольору.");
            }

            Console.ReadKey();
        }

        static void Red()
        {
            Console.WriteLine("Колір: Червоний");
            Console.WriteLine("Код RGB: #FF0000");
        }

        static void Orange()
        {
            Console.WriteLine("Колір: Помаранчовий");
            Console.WriteLine("Код RGB: #FFA500");
        }

        static void Yellow()
        {
            Console.WriteLine("Колір: Жовтий");
            Console.WriteLine("Код RGB: #FFFF00");
        }

        static void Green()
        {
            Console.WriteLine("Колір: Зелений");
            Console.WriteLine("Код RGB: #008000");
        }

        static void Cyan()
        {
            Console.WriteLine("Колір: Блакитний");
            Console.WriteLine("Код RGB: #00FFFF");
        }

        static void Blue()
        {
            Console.WriteLine("Колір: Синій");
            Console.WriteLine("Код RGB: #0000FF");
        }

        static void Violet()
        {
            Console.WriteLine("Колір: Фіолетовий");
            Console.WriteLine("Код RGB: #8A2BE2");
        }
    }
}
