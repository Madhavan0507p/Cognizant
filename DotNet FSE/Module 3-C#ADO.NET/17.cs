using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Contact? contact = null;
        Console.WriteLine($"Contact Name: {contact?.Name ?? "No contact"}");

        contact = new Contact();
        Console.WriteLine($"Contact Name: {contact?.Name ?? "No name"}");

        contact.Name = "Alice";
        Console.WriteLine($"Contact Name: {contact?.Name ?? "No name"}");
    }
}
