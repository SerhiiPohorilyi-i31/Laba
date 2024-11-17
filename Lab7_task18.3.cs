using System;

namespace Lecture8.Example3
{
    // Універсальний клас з одним параметром T
    class GenericClass<T> where T : IComparable<T>
    {
        private T value1;
        private T value2;

        // Конструктор для ініціалізації значень
        public GenericClass(T value1, T value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        // Метод для знаходження меншого з двох чисел
        public T FindMin()
        {
            return value1.CompareTo(value2) < 0 ? value1 : value2;
        }

        // Метод для відображення значень
        public void DisplayValues()
        {
            Console.WriteLine($"Значення 1: {value1}, Значення 2: {value2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Приклад з цілими числами
            GenericClass<int> intPair = new GenericClass<int>(10, 20);
            intPair.DisplayValues();
            Console.WriteLine($"Менше значення: {intPair.FindMin()}");
            Console.WriteLine();
        }
    }
}


