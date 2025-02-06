using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop03 World!");
        Word myWord = new Word("Hello", true);

        Console.WriteLine($"Word: {myWord.GetWord()}");
        
        myWord.SetHidden(false);

        Console.WriteLine($"Word: {myWord.GetWord()}");
    }
}