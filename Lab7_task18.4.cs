using System;
using System.Collections;
using System.Collections.Generic;

// Клас "Рослина"
public class Plant
{
    private string name;
    private double price;

    public Plant(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public override string ToString()
    {
        return $"Рослина: {Name}, Ціна: {Price}";
    }
}

// Універсальний клас GenericList<T> для роботи зі списком рослин
public class GenericList<T> where T : Plant
{
    private class Node
    {
        public Node Next { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;

    public GenericList()
    {
        head = null;
    }

    // Додати рослину в початок списку
    public void AddHead(T data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    // Перерахунок елементів списку
    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    // Знайти перше входження за назвою
    public T FindFirstOccurrence(string name)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Name == name)
            {
                return current.Data;
            }
            current = current.Next;
        }
        return null;
    }
}

// Основний клас для тестування
class Program
{
    static void Main(string[] args)
    {
        // Створення списку рослин
        GenericList<Plant> plantList = new GenericList<Plant>();

        // Додавання рослин
        plantList.AddHead(new Plant("Троянда", 150.50));
        plantList.AddHead(new Plant("Ромашка", 200.75));
        plantList.AddHead(new Plant("Тюльпан", 100.00));

        // Виведення всіх рослин
        Console.WriteLine("Список рослин:");
        foreach (var plant in plantList)
        {
            Console.WriteLine(plant);
        }

        Console.WriteLine();

        // Пошук рослини за назвою
        string searchName = "Тюльпан";
        Plant foundPlant = plantList.FindFirstOccurrence(searchName);
        if (foundPlant != null)
        {
            Console.WriteLine($"Знайдено рослину: {foundPlant}");
        }
        else
        {
            Console.WriteLine($"Рослину з назвою \"{searchName}\" не знайдено.");
        }
    }
}

