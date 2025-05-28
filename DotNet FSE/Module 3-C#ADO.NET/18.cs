using System;

class Student
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Compiler will force to initialize required properties
        Student s1 = new Student
        {
            Name = "Praveen",
            Age = 19
        };

        Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");

        // Student s2 = new Student(); // Error: required properties not set
    }
}
