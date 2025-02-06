using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Verse myVerse = new Verse("This is my Verse!");

        myVerse.DisplayVerse();
        
    }
}