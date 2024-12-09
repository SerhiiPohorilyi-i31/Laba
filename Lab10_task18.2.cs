using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Вказуємо шлях до існуючого файлу
            string filePath = @"/Users/mb_skk/Projects/Lab10_task18.2/text1.txt";

            // Перевіряємо, чи файл існує
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл за вказаним шляхом не знайдено. Перевірте правильність шляху.");
                return;
            }

            // Зчитуємо текст із файлу
            string text = File.ReadAllText(filePath);

            // Виводимо текст для зручності
            Console.WriteLine("Текст із файлу:");
            Console.WriteLine(text);

            // Зчитуємо слово для пошуку
            Console.WriteLine("\nВведіть слово для пошуку:");
            string word = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Ви не ввели слово для пошуку.");
                return;
            }

            // Пошук слова (без врахування регістру)
            int wordCount = text
                .Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Count(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));

            // Вивід результату
            Console.WriteLine($"\nСлово \"{word}\" повторюється {wordCount} раз(ів) у тексті.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}
