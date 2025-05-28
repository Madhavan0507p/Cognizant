using System;

class Product
{
    public string Name { get; set; }

    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            if (value >= 0)
                _price = value;
            else
                Console.WriteLine("Invalid Price. Must be non-negative.");
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product();
        p.Name = "Laptop";
        p.Price = 1000;
        Console.WriteLine($"{p.Name} - ${p.Price}");

        p.Price = -50; // Should trigger validation
    }
}
