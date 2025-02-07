using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ScriptureLibrary myLibrary = new ScriptureLibrary();
        Verse myVerse = myLibrary.GetScripture();
        string userInput = "";

        myVerse.DisplayVerse();
        while(myVerse.CheckAllHidden() == false)
        {
            
            Console.WriteLine("--Press 'ENTER to contine");
            Console.WriteLine("--Type a number to remove that many words");
            Console.WriteLine("--Type 'quit' to quit");
            userInput = Console.ReadLine();
            if(userInput == "quit")
            {
                break;
            }else if(userInput == "display all")
            {
                Console.Clear();
                myLibrary.DisplayScriptures();
            }else if(userInput != "")                       //This section of code checks if the input is an integer and if so, will hide that many words
            {
                try
                {
                    int userNum = int.Parse(userInput);
                    myVerse.HideWords(userNum);
                    Console.Clear();
                    myVerse.DisplayVerse();
                }catch(Exception e)                         //If the input cannot be parsed, it will still continue
                {
                    Console.Clear();
                    myVerse.DisplayVerse();
                    Console.WriteLine(e.Message);
                }   
            }else                //Default will be 3 words removed
            {
            myVerse.HideWords(3);
            Console.Clear();
            myVerse.DisplayVerse();
            } 
        }
    }
}