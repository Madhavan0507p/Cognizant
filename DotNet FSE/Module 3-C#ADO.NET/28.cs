using System;
using System.Diagnostics;
using System.IO;

class Logger
{
    public Logger()
    {
        TextWriterTraceListener fileListener = new TextWriterTraceListener("log.txt");
        Trace.Listeners.Add(fileListener);
        Trace.AutoFlush = true;
    }

    public void Log(string message)
    {
        Trace.WriteLine($"{DateTime.Now}: {message}");
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger();
        logger.Log("Application started.");
        logger.Log("Performing some actions...");
        logger.Log("Application ended.");
    }
}
