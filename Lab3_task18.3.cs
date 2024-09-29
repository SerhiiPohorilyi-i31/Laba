using System;

class Student
{
    // Масив оцінок за 10 дисциплін
    private int[] grades = new int[10];

    // Визначення індексатора для доступу до елементів масиву оцінок
    public int this[int index]
    {
        get => grades[index];
        set
        {
            if (value >= 0 && value <= 100) // Оцінка повинна бути в діапазоні 0-100
                grades[index] = value;
            else
                Console.WriteLine("Оцінка має бути в діапазоні від 0 до 100!");
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
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Student
        Student student = new Student();

        // Ініціалізація оцінок студента через індексатор
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

        // Виведення всіх оцінок студента
        Console.WriteLine("Оцінки студента:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Оцінка #{i + 1} = {student[i]}");
        }

        // Обчислення та виведення середнього рейтингу
        double averageRating = student.CalculateAverageRating();
        Console.WriteLine($"\nСередній рейтинг студента: {averageRating:F2}");

        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
