using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Email { get; set; } = "";
}

class Program
{
    static void Main()
    {
        var user = new User { Name = "Praveen", Age = 19, Email = "praveen@example.com" };

        // Serialize to JSON string and save to file
        string jsonString = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", jsonString);
        Console.WriteLine("User serialized to user.json");

        // Deserialize from file
        string readJson = File.ReadAllText("user.json");
        User? deserializedUser = JsonSerializer.Deserialize<User>(readJson);

        if (deserializedUser != null)
        {
            Console.WriteLine($"Name: {deserializedUser.Name}, Age: {deserializedUser.Age}, Email: {deserializedUser.Email}");
        }
    }
}
