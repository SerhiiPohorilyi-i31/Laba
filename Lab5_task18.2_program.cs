// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо екземпляри класів Дерево і Квіти
        Tree oakTree = new Tree("Oak", "Large and strong tree", 150.0, 5);
        Flower rose = new Flower("Rose", "Beautiful red flower", 20.0, 12);

        // Виводимо інформацію про рослини
        Console.WriteLine($"Tree: {oakTree.Name}, {oakTree.About}, Price: {oakTree.Get_Price()}, Quantity: {oakTree.Count()}");
        Console.WriteLine($"Flower: {rose.Name}, {rose.About}, Price: {rose.Get_Price()}, Quantity: {rose.Count()}");
    }
}