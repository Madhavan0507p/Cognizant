using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = "";
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>
        {
            new() { OrderId = 1, CustomerName = "Alice", TotalAmount = 250 },
            new() { OrderId = 2, CustomerName = "Bob", TotalAmount = 150 },
            new() { OrderId = 3, CustomerName = "Charlie", TotalAmount = 300 },
        };

        var filtered = orders
            .Where(o => o.TotalAmount > 200)
            .Select(o => new { o.OrderId, o.CustomerName });

        Console.WriteLine("Orders with amount > 200:");
        foreach (var order in filtered)
        {
            Console.WriteLine($"OrderId: {order.OrderId}, Customer: {order.CustomerName}");
        }
    }
}
