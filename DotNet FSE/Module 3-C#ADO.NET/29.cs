using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter user input:");
        string? input = Console.ReadLine();

        if (input != null)
        {
            string sanitizedInput = WebUtility.HtmlEncode(input);
            Console.WriteLine($"Sanitized input: {sanitizedInput}");
        }
    }
}
