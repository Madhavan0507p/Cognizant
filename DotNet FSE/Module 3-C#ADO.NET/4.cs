using System;

class MyClass { }

class Program
{
    static void Main()
    {
        var number = 10;
        var text = "Hello";
        var obj = new MyClass();

        Console.WriteLine($"number is of type {number.GetType()}");
        Console.WriteLine($"text is of type {text.GetType()}");
        Console.WriteLine($"obj is of type {obj.GetType()}");
    }
}
