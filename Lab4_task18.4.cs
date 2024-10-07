using System;

namespace StaticClassExample
{
    // Статичний клас для виконання операцій над масивами
    static class ArrayOperations
    {
        // Метод для знаходження мінімального і максимального елементів за допомогою лінійного пошуку
        public static void FindMinMax(int[] array, out int min, out int max)
        {
            // Ініціалізація мінімального та максимального значень
            min = array[0];
            max = array[0];

            // Лінійний пошук мінімуму та максимуму
            foreach (int element in array)
            {
                if (element < min)
                    min = element;

                if (element > max)
                    max = element;
            }
        }

        // Метод для двійкового пошуку елемента в відсортованому масиві
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            // Якщо елемент не знайдено
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1: Лінійний пошук для визначення мінімального та максимального елементів
            int[] array1 = { 4, 5, 2, 3, 8, 7, 6, 1 };
            Console.WriteLine("Масив: {0}", string.Join(", ", array1));

            // Виклик статичного методу для пошуку мінімального та максимального елементів
            ArrayOperations.FindMinMax(array1, out int min, out int max);
            Console.WriteLine($"Мінімальний елемент: {min}");
            Console.WriteLine($"Максимальний елемент: {max}");

            // Завдання 2: Двійковий пошук у відсортованому масиві
            int[] sortedArray = new int[100];

            // Ініціалізація відсортованого масиву від 1 до 100
            for (int i = 0; i < 100; i++)
                sortedArray[i] = i + 1;

            Console.WriteLine("\nВідсортований масив: {0}", string.Join(", ", sortedArray));

            // Пошук елемента 80 у відсортованому масиві
            int targetElement = 80;
            int index = ArrayOperations.BinarySearch(sortedArray, targetElement);

            if (index != -1)
                Console.WriteLine($"Елемент {targetElement} знайдено на індексі {index}.");
            else
                Console.WriteLine($"Елемент {targetElement} не знайдено в масиві.");

            Console.ReadKey();
        }
    }
}


