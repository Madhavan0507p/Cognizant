using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";

        // Write text to file for reading demonstration
        File.WriteAllText(filePath, "Hello, FileStream!");

        // Reading from file using FileStream
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            string text = Encoding.UTF8.GetString(buffer);
            Console.WriteLine($"File content: {text}");
        }

        // Writing to MemoryStream
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello, MemoryStream!");
            ms.Write(data, 0, data.Length);
            Console.WriteLine($"Bytes written to MemoryStream: {ms.Length}");
        }
    }
}
