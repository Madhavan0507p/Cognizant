using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Data Source=localhost;Initial Catalog=YourDatabaseName;Integrated Security=True";

    static void Main()
    {
        InsertEmployee(1, "Praveen", 25);
        ReadEmployees();
        UpdateEmployee(1, "Praveen P", 26);
        DeleteEmployee(1);
    }

    static void InsertEmployee(int id, string name, int age)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "INSERT INTO Employees (Id, Name, Age) VALUES (@Id, @Name, @Age)";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Age", age);
        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine($"{rows} row(s) inserted.");
    }

    static void ReadEmployees()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "SELECT Id, Name, Age FROM Employees";
        using SqlCommand cmd = new SqlCommand(query, con);
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Age: {reader.GetInt32(2)}");
        }
    }

    static void UpdateEmployee(int id, string newName, int newAge)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "UPDATE Employees SET Name=@Name, Age=@Age WHERE Id=@Id";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", newName);
        cmd.Parameters.AddWithValue("@Age", newAge);
        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine($"{rows} row(s) updated.");
    }

    static void DeleteEmployee(int id)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string query = "DELETE FROM Employees WHERE Id=@Id";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine($"{rows} row(s) deleted.");
    }
}
