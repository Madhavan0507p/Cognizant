using System;

class Program
{
    static void Main()
    {
        int refVal = 10;
        UpdateValueRef(ref refVal);
        Console.WriteLine("ref: " + refVal);

        int outVal;
        AssignValueOut(out outVal);
        Console.WriteLine("out: " + outVal);

        int inVal = 5;
        ShowValueIn(in inVal);
    }

    static void UpdateValueRef(ref int x)
    {
        x += 5;
    }

    static void AssignValueOut(out int x)
    {
        x = 100;
    }

    static void ShowValueIn(in int x)
    {
        Console.WriteLine("in: " + x);
    }
}
