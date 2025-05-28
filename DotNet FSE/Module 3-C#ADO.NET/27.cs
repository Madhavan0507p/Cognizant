using System;
using System.Threading;

class Program
{
    static readonly object lockA = new object();
    static readonly object lockB = new object();

    static void Thread1()
    {
        lock (lockA)
        {
            Thread.Sleep(100);
            lock (lockB)
            {
                Console.WriteLine("Thread1 acquired both locks.");
            }
        }
    }

    static void Thread2()
    {
        lock (lockB)
        {
            Thread.Sleep(100);
            lock (lockA)
            {
                Console.WriteLine("Thread2 acquired both locks.");
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Completed without resolving deadlock (may hang).");
    }
}
