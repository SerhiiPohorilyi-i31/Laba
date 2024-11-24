using System;

namespace ArithmeticCalculator
{
    class Program
    {
        // Універсальний делегат
        delegate T ArithmeticOperation<T>(T a, T b);

        static void Main(string[] args)
        {
            Console.WriteLine("Арифметичний калькулятор");
            Console.WriteLine("Оберіть операцію: +, -, *, /");
            string operation = Console.ReadLine();

            Console.WriteLine("Введіть перше число:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введіть друге число:");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                PerformOperation(operation, num1, num2);
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Спробуйте ще раз.");
            }
        }

        static void PerformOperation<T>(string operation, T num1, T num2) where T : struct
        {
            ArithmeticOperation<T> arithmetic = null;

            switch (operation)
            {
                case "+":
                    arithmetic = Add;
                    break;
                case "-":
                    arithmetic = Subtract;
                    break;
                case "*":
                    arithmetic = Multiply;
                    break;
                case "/":
                    arithmetic = Divide;
                    break;
                default:
                    Console.WriteLine("Некоректна операція. Спробуйте ще раз.");
                    return;
            }

            if (arithmetic != null)
            {
                T result = arithmetic(num1, num2);
                Console.WriteLine($"Результат: {result}");
            }
        }

        static T Add<T>(T a, T b) where T : struct
        {
            return (dynamic)a + (dynamic)b;
        }

        static T Subtract<T>(T a, T b) where T : struct
        {
            return (dynamic)a - (dynamic)b;
        }

        static T Multiply<T>(T a, T b) where T : struct
        {
            return (dynamic)a * (dynamic)b;
        }

        static T Divide<T>(T a, T b) where T : struct
        {
            if ((dynamic)b == 0)
            {
                Console.WriteLine("Помилка: Ділення на нуль неможливе.");
                return default;
            }

            return (dynamic)a / (dynamic)b;
        }
    }
}
