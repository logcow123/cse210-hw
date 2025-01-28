using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Entry newEntry = new Entry();

        newEntry.WriteEntry();

        Console.WriteLine();
        newEntry.ReadEntry();

    }
}