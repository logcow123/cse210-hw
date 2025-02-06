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
            
            Console.WriteLine("Press 'ENTER to contine or type 'quit' to quit or type a number to remove that many words");
            userInput = Console.ReadLine();
            if(userInput == "quit")
            {
                break;
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