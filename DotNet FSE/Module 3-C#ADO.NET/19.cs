using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        Dictionary<int, string> employees = new Dictionary<int, string>
        {
            { 1, "Praveen" },
            { 2, "Alice" },
            { 3, "Bob" }
        };

        Console.WriteLine("Fruits:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nEmployees:");
        foreach (var kvp in employees)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }

        // Add and remove
        fruits.Add("Date");
        employees.Remove(2);

        Console.WriteLine("\nUpdated Fruits:");
        fruits.ForEach(f => Console.WriteLine(f));

        Console.WriteLine("\nUpdated Employees:");
        foreach (var kvp in employees)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}
