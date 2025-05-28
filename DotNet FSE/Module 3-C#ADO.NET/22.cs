using System;

class Program
{
    static (int, string) GetTuple()
    {
        return (42, "Answer to everything");
    }

    static void Main()
    {
        var (number, text) = GetTuple();
        Console.WriteLine($"Number: {number}, Text: {text}");
    }
}
