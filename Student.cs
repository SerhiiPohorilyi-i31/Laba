using System;

class Student
{
    // Закриті поля класу
    private string name;
    private int age;
    private int course;
    private double rating;

    // Властивості для доступу до полів
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
        }
    }

    public int Course
    {
        get { return course; }
        set
        {
            if (value >= 1 && value <= 3) // В університеті 6 курсів
                course = value;
        }
    }

    public double Rating
    {
        get { return rating; }
        set
        {
            if (value >= 0 && value <= 100) // Рейтинг від 0 до 100
                rating = value;
        }
    }

    // Конструктор з параметрами
    public Student(string name, int age, int course, double rating)
    {
        this.name = name;
        this.age = age;
        this.course = course;
        this.rating = rating;
    }

    // Метод для редагування даних студента
    public void EditStudent(string newName, int newAge, double newRating)
    {
        Name = newName;
        Age = newAge;
        Rating = newRating;
    }

    // Метод для виведення рейтингу студента
    public void StudentRating()
    {
        Console.WriteLine($"Рейтинг студента {Name}: {Rating}");
    }

    // Метод для визначення, бакалавр чи магістр студент
    public string GetRole()
    {
        if (course <= 4)
            return "Бакалавр";
        else
            return "Магістр";
    }
}

class ConsoleProgram
{
    static void Main()
    {
        // Створення нового студента
        Student student = new Student("Сергій Дмитренко", 25, 2, 95.5);

        // Виведення інформації про студента
        Console.WriteLine($"Ім'я: {student.Name}");
        Console.WriteLine($"Вік: {student.Age}");
        Console.WriteLine($"Курс: {student.Course}");
        Console.WriteLine($"Роль: {student.GetRole()}");

        // Виведення рейтингу студента
        student.StudentRating();
    }
}



