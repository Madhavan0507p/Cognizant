using System;

public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
}

class Program
{
    static void Main()
    {
        var emp1 = new Employee { Id = 1, Name = "Alice" };
        Console.WriteLine(emp1);

        var emp2 = emp1 with { Name = "Bob" };
        Console.WriteLine(emp2);

        // emp1.Name = "Charlie"; // Error: init-only
    }
}
