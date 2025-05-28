using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Using for loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 30) continue;
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Using foreach loop:");
        foreach (int num in numbers)
        {
            if (num == 40) break;
            Console.WriteLine(num);
        }

        Console.WriteLine("Using while loop:");
        int j = 0;
        while (j < numbers.Length)
        {
            Console.WriteLine(numbers[j]);
            if (numbers[j] == 50) break;
            j++;
        }

        Console.WriteLine("Using do-while loop:");
        int k = 0;
        do
        {
            Console.WriteLine(numbers[k]);
            k++;
        } while (k < numbers.Length);
    }
}
