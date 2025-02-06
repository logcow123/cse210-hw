using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Verse myVerse = new Verse("This is my Verse!");
        Reference myReference = new Reference();

        myVerse.DisplayVerse();
        Console.WriteLine($"are all the words hidden: {myVerse.CheckAllHidden()}");

        Console.WriteLine(myReference.GetFullReference());

        myReference = new Reference("Priverbs 5:6-10");
        Console.WriteLine($"Parsed Reference: {myReference.GetFullReference()}");
        myReference = new Reference("Bromethians 6:9");
        Console.WriteLine($"Parsed Reference: {myReference.GetFullReference()}");


        
    }
}