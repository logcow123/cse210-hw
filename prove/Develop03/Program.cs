using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Verse myVerse = new Verse("Bruh 5:1-2","This is my Verse! Here are a ton more words to show you an example of hiding words!");
        string userInput = "";

        myVerse.DisplayVerse();
        while(myVerse.CheckAllHidden() == false)
        {
            
            Console.WriteLine("Press 'ENTER to contine or type 'quit' to guit");
            userInput = Console.ReadLine();
            if(userInput == "quit")
            {
                break;
            }
            myVerse.HideWords(7);
            Console.Clear();
            myVerse.DisplayVerse();
        }


        
    }
}