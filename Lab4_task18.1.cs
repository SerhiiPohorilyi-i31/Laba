using System;

namespace StudentRatingSystem
{
    // Базовий клас Person
    class Person
    {
        public string Name { get; set; }  // Ім'я
        public int Age { get; set; }      // Вік
        public string Role { get; set; }  // Роль

        public Person(string N, string R, int A)
        {
            Name = N;
            Age = A;
            Role = R;
        }

        public string GetName()
        {
            return Name;
        }
    }

    // Клас для оцінок студента за модулі
    class StudentAssesment
    {
        double[] assesment = new double[10];

        // Метод для розрахунку середнього рейтингу
        public double StRating(Random arand)
        {
            double rating = 0;
            Console.WriteLine("Оцінки за модуль:");
            for (int i = 0; i < 10; i++)
            {
                assesment[i] = arand.Next(56, 100);  // Генерація випадкових оцінок від 56 до 100
                rating += assesment[i];
                Console.Write(assesment[i].ToString() + ", ");
            }
            Console.WriteLine();
            return rating / 10;  // Повертаємо середній рейтинг за 10 дисциплін
        }
    }

    // Клас студент
    class Student : Person
    {
        public string Facultet { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }

        public Student(string N, string R, int A, string F, string G, int C)
            : base(N, R, A)
        {
            Facultet = F;
            Group = G;
            Course = C;
        }

        // Створення екземплярів класу StudentAssesment для двох модулів
        StudentAssesment strating1 = new StudentAssesment();
        StudentAssesment strating2 = new StudentAssesment();

        // Метод для обчислення середнього рейтингу за два модулі
        public void MyRating(Random arand)
        {
            // Рейтинг за перший модуль
            Console.WriteLine("Рейтинг за перший модуль:");
            double Rating1 = strating1.StRating(arand);

            // Рейтинг за другий модуль
            Console.WriteLine("Рейтинг за другий модуль:");
            double Rating2 = strating2.StRating(arand);

            // Середній рейтинг за семестр
            double SemesterRating = (Rating1 + Rating2) / 2;
            Console.WriteLine($"Середній рейтинг за семестр = {SemesterRating}");

            // Виведення повідомлень залежно від рейтингу
            if (SemesterRating >= 82)
                Console.WriteLine("Привіт відмінникам!");
            else if (SemesterRating <= 60)
                Console.WriteLine("Перездача! Треба краще вчитися!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра класу Student
            Student newSt = new Student("Іванов", "студент", 20, "КННІ", "K-01", 3);

            // Ініціалізація генератора випадкових чисел
            Random arand = new Random();

            // Обчислення рейтингу студента
            newSt.MyRating(arand);

            // Затримка для перегляду результатів
            Console.ReadKey();
        }
    }
}

