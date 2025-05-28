using System;

class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person? person = null;

        // Null-conditional operator ?. to safely access Name
        Console.WriteLine(person?.Name ?? "Name is null");

        person = new Person();
        Console.WriteLine(person?.Name ?? "Name is null");

        person.Name = "Praveen";
        Console.WriteLine(person?.Name ?? "Name is null");
    }
}
