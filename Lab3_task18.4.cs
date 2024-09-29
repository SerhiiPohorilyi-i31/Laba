using System;

class Student
{
    // Масив для зберігання оцінок з різних дисциплін (10 елементів)
    private int[] grades = new int[10];

    // Індексатор для доступу до елементів масиву оцінок
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < grades.Length)
                return grades[index];
            else
                throw new IndexOutOfRangeException("Неприпустимий індекс!");
        }
        set
        {
            if (index >= 0 && index < grades.Length)
            {
                if (value >= 0 && value <= 100) // Оцінка має бути в діапазоні від 0 до 100
                    grades[index] = value;
                else
                    Console.WriteLine("Оцінка повинна бути в діапазоні від 0 до 100!");
            }
            else
                throw new IndexOutOfRangeException("Неприпустимий індекс!");
        }
    }

    // Метод для обчислення середнього рейтингу студента
    public double CalculateAverageRating()
    {
        int sum = 0;
        int count = grades.Length;
        for (int i = 0; i < count; i++)
        {
            sum += grades[i];
        }
        return (double)sum / count;
    }

    // Метод для виведення всіх оцінок на екран
    public void PrintGrades()
    {
        Console.WriteLine("Оцінки студента:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Дисципліна #{i + 1}: {grades[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Student
        Student student = new Student();

        // Ініціалізація масиву оцінок через індексатор
        student[0] = 83;
        student[1] = 91;
        student[2] = 73;
        student[3] = 87;
        student[4] = 90;
        student[5] = 65;
        student[6] = 86;
        student[7] = 55;
        student[8] = 97;
        student[9] = 89;

        // Виклик методу для виведення всіх оцінок на екран
        student.PrintGrades();

        // Розрахунок середнього рейтингу студента
        double averageRating = student.CalculateAverageRating();

        // Виведення середнього рейтингу на екран
        Console.WriteLine($"\nСередній рейтинг студента: {averageRating:F2}");

        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
