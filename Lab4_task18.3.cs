using System;

namespace FacultySystem
{
    // Базовий клас Person (залишаємо як в завданні 18.1, початковому прикладі)
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

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

    // Клас Факультет
    class Faculty
    {
        public string FacultyName { get; set; } // Назва факультету

        // Вкладений частковий клас Кафедра (частина 1)
        public partial class Department
        {
            public string DepartmentName { get; set; }  // Назва кафедри
            public int NumberOfTeachers { get; set; }   // Кількість викладачів

            // Метод для встановлення назви кафедри
            public void SetDepartmentName(string name)
            {
                DepartmentName = name;
            }

            // Метод для введення кількості викладачів
            public void SetNumberOfTeachers(int count)
            {
                NumberOfTeachers = count;
            }

            // Метод для відображення інформації про кафедру
            public void ShowDepartmentInfo()
            {
                Console.WriteLine($"Кафедра: {DepartmentName}, Викладачів: {NumberOfTeachers}");
                ShowSubjects();
                Console.WriteLine();
            }
        }

        // Вкладений частковий клас Кафедра (частина 2)
        public partial class Department
        {
            private string[] subjects = new string[5];  // Масив дисциплін

            // Індексатор для ініціалізації дисциплін кафедри
            public string this[int index]
            {
                get { return subjects[index]; }
                set { subjects[index] = value; }
            }

            // Метод для відображення дисциплін кафедри
            public void ShowSubjects()
            {
                Console.WriteLine("Дисципліни кафедри:");
                foreach (var subject in subjects)
                {
                    if (!string.IsNullOrEmpty(subject))
                        Console.WriteLine("- " + subject);
                }
            }
        }

        // Екземпляри класу Кафедра
        Department dept1 = new Department();
        Department dept2 = new Department();

        // Метод для встановлення інформації про факультет
        public void SetFacultyInfo(string facultyName)
        {
            FacultyName = facultyName;
        }

        // Метод для налаштування та відображення інформації про кафедри
        public void ConfigureDepartments()
        {
            // Встановлення інформації для першої кафедри
            dept1.SetDepartmentName("Комп'ютерні науки");
            dept1.SetNumberOfTeachers(10);
            dept1[0] = "Обєктно-орінтоване програмування";
            dept1[1] = "Алгоритми та структури даних";
            dept1[2] = "Операційні системи";
            dept1[3] = "Бази даних";
            dept1[4] = "Комп'ютерні мережі";

            // Встановлення інформації для другої кафедри
            dept2.SetDepartmentName("Вища математика");
            dept2.SetNumberOfTeachers(5);
            dept2[0] = "Лінійна алгебра";
            dept2[1] = "Дискретна математика";
            dept2[2] = "Математичний аналіз";
            dept2[3] = "Теорія ймовірностей";
            dept2[4] = "Диференціальні рівняння";

            // Відображення інформації про кафедри
            Console.WriteLine($"Факультет: {FacultyName}");
            dept1.ShowDepartmentInfo();
            dept2.ShowDepartmentInfo();
        }
    }

    // Клас для тестування функціоналу
    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра класу Факультет
            Faculty faculty = new Faculty();

            // Встановлення інформації про факультет
            faculty.SetFacultyInfo("Факультет Комп'ютерних наук");

            // Налаштування та відображення інформації про кафедри
            faculty.ConfigureDepartments();

            // Затримка для перегляду результатів
            Console.ReadKey();
        }
    }
}
