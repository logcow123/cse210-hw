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

        myReference.ParseReferefce("Proverbs 5:6-7");
        Console.WriteLine($"Parsed Reference: {myReference.GetFullReference()}");
        myReference.ParseReferefce("John 3:16");
        Console.WriteLine($"Parsed Reference: {myReference.GetFullReference()}");


        
    }
}