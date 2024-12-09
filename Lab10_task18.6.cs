using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 42, 32, 25, 18, 27, 58, 78 };

        // Вибір 3 чисел, починаючи з третього (індекс 2)
        var selectedNumbers = numbers.Skip(2).Take(3);

        // Виведення вибраних чисел
        Console.WriteLine("Вибрані числа:");
        foreach (var num in selectedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}


