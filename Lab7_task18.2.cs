using System;

namespace Lab7.Task18_2
{
    class Program
    {
        // Універсальний метод пошуку мінімального елемента
        static T FindMin<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім.");

            T min = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        // Універсальний метод пошуку максимального елемента
        static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім.");

            T max = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            // Масив цілих чисел
            int[] intArray = { 5, 3, 8, 1, 4 };

            int minInt = FindMin(intArray);
            int maxInt = FindMax(intArray);

            Console.WriteLine("Масив цілих чисел: " + string.Join(", ", intArray));
            Console.WriteLine($"Мінімальне значення: {minInt}");
            Console.WriteLine($"Максимальне значення: {maxInt}");
            Console.WriteLine();

            // Масив дійсних чисел
            double[] doubleArray = { 2.5, 3.1, 0.5, 7.8, 1.6 };

            double minDouble = FindMin(doubleArray);
            double maxDouble = FindMax(doubleArray);

            Console.WriteLine("Масив дійсних чисел: " + string.Join(", ", doubleArray));
            Console.WriteLine($"Мінімальне значення: {minDouble}");
            Console.WriteLine($"Максимальне значення: {maxDouble}");
        }
    }
}


