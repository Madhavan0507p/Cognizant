public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void DisplayInfo() => Console.WriteLine($"Name: {Name}, Age: {Age}");
}

class Program
{
    static void Main()
    {
        var person = new Person("Alice", 30);
        person.DisplayInfo();
    }
}
