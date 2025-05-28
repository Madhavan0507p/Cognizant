using System;

class Program
{
    static void DisplayObjectInfo(object obj)
    {
        if (obj is int i)
        {
            Console.WriteLine($"Integer: {i}");
        }
        else if (obj is string s)
        {
            Console.WriteLine($"String: {s}");
        }
        else
        {
            Console.WriteLine("Unknown type");
        }

        switch (obj)
        {
            case int n when n > 0:
                Console.WriteLine("Positive integer");
                break;
            case int n:
                Console.WriteLine("Integer");
                break;
            case string str when str.Length > 5:
                Console.WriteLine("Long string");
                break;
            case string:
                Console.WriteLine("Short string");
                break;
            default:
                Console.WriteLine("Other type");
                break;
        }
    }

    static void Main()
    {
        DisplayObjectInfo(10);
        DisplayObjectInfo(-5);
        DisplayObjectInfo("Hello");
        DisplayObjectInfo("Hello, world!");
        DisplayObjectInfo(3.14);
    }
}
