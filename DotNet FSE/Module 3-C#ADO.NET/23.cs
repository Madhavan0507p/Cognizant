using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> UploadFileAsync()
    {
        try
        {
            Console.WriteLine("Uploading file...");
            await Task.Delay(3000);  // simulate upload delay
            return "Upload successful";
        }
        catch (Exception ex)
        {
            return $"Upload failed: {ex.Message}";
        }
    }

    static async Task Main()
    {
        string result = await UploadFileAsync();
        Console.WriteLine(result);
    }
}
