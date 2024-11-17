using System;

namespace Lecture8.Example1
{
    class Program
    {
        // Універсальний метод для обміну даними будь-якого типу
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            // Приклад з типом double
            double x = 2.5;
            double y = 3.5;

            Console.WriteLine("До обміну:");
            Console.WriteLine($"x = {x}, y = {y}");

            Swap<double>(ref x, ref y);

            Console.WriteLine("Після обміну:");
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine();

            // Приклад з типом string
            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine("До обміну:");
            Console.WriteLine($"str1 = {str1}, str2 = {str2}");

            Swap<string>(ref str1, ref str2);

            Console.WriteLine("Після обміну:");
            Console.WriteLine($"str1 = {str1}, str2 = {str2}");
        }
    }
}


