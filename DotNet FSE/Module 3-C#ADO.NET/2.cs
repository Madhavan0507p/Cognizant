using System;

class MyClass
{
    public int Number;
}

class Program
{
    static void ModifyValue(int x) => x = 100;
    static void ModifyReference(MyClass obj) => obj.Number = 100;

    static void Main()
    {
        int a = 10;
        MyClass b = new MyClass { Number = 10 };

        ModifyValue(a);
        ModifyReference(b);

        Console.WriteLine($"Value Type: {a}");          // Output: 10
        Console.WriteLine($"Reference Type: {b.Number}"); // Output: 100
    }
}
