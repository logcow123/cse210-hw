using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Word myWord = new Word();
        myWord.SetWord("Hello");

        Console.WriteLine($"Word: {myWord.GetWord()}");
        
        myWord.SetHidden(true);

        Console.WriteLine($"Word: {myWord.GetWord()}");
    }
}