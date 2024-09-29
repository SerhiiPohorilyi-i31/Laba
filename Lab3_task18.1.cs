using System;
using System.Text;
using System.IO;

namespace Person1
{
    class Person
    {
        const int l_name = 30; // Макс. довжина прізвища
        string name;
        int birth_year;
        double pay;

        // Конструктор без параметрів
        public Person()
        {
            name = "Anonimous";
            birth_year = 0;
            pay = 0;
        }

        // Конструктор з параметром рядка
        public Person(string[] words) // Конструктор приймає масив слів
        {
            name = words[0] + " " + words[1]; // Прізвище та ініціали
            birth_year = Convert.ToInt32(words[2]); // Рік народження
            pay = Convert.ToDouble(words[3]); // Оклад

            if (birth_year < 0) throw new FormatException();
            if (pay < 0) throw new FormatException();
        }

        // Перевизначений метод ToString()
        public override string ToString()
        {
            return string.Format("Name: {0,30} birth: {1} pay: {2:F2}", name, birth_year, pay);
        }

        public int Compare(string name) // порівняння прізвища
        {
            return (string.Compare(this.name, 0, name + " ", 0, name.Length + 1, StringComparison.OrdinalIgnoreCase));
        }

        // --------------------  властивості класу --------------------------
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Birth_year
        {
            get { return birth_year; }
            set
            {
                if (value > 0) birth_year = value;
                else throw new FormatException();
            }
        }

        public double Pay
        {
            get { return pay; }
            set
            {
                if (value > 0) pay = value;
                else throw new FormatException();
            }
        }

        // ------------------  операції класу ---------------------------
        public static double operator +(Person pers, double a)
        {
            pers.pay += a;
            return pers.pay;
        }

        public static double operator +(double a, Person pers)
        {
            pers.pay += a;
            return pers.pay;
        }

        public static double operator -(Person pers, double a)
        {
            pers.pay -= a;
            if (pers.pay < 0) throw new FormatException();
            return pers.pay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] dbase = new Person[100];
            int n = 0;

            try
            {
                // Відкриваємо файл
                StreamReader f = new StreamReader("d:\\Persons.txt");
                string s;
                int i = 0;

                // Зчитуємо рядки з файлу
                while ((s = f.ReadLine()) != null)
                {
                    // Розбиваємо рядок на окремі слова
                    string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (words.Length == 4) // Якщо кількість слів відповідає очікуваній
                    {
                        dbase[i] = new Person(words);
                        Console.WriteLine(dbase[i]);
                        ++i;
                    }
                    else
                    {
                        Console.WriteLine("Неправильний формат даних у рядку: " + s);
                    }
                }

                n = i;
                f.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Перевірте правильність імені і шляху до файлу!");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Дуже великий файл!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Неприпустима дата народження або оклад");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
                return;
            }

            // Пошук співробітника за прізвищем
            int n_pers = 0;
            double mean_pay = 0;
            Console.WriteLine("Введіть прізвище співробітника:");
            string name;

            while ((name = Console.ReadLine()) != "")
            {
                bool not_found = true;

                for (int k = 0; k < n; ++k)
                {
                    Person pers = dbase[k];
                    if (pers.Compare(name) == 0)
                    {
                        Console.WriteLine(pers);
                        ++n_pers;
                        mean_pay += pers.Pay;
                        not_found = false;
                    }
                }

                if (not_found) Console.WriteLine("Такого співробітника немає");
                Console.WriteLine("Введіть прізвище співробітника або Enter для завершення");
            }

            if (n_pers > 0)
                Console.WriteLine("Середній оклад: {0:F2}", mean_pay / n_pers);

            Console.ReadKey();
        }
    }
}
