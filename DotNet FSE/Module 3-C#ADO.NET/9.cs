using System;

class Program
{
    static void Main()
    {
        int number = 5;
        int result = CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} is {result}");
    }

    static int CalculateFactorial(int n)
    {
        int Factorial(int x)
        {
            return (x <= 1) ? 1 : x * Factorial(x - 1);
        }

        return Factorial(n);
    }
}
