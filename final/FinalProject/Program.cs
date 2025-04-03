using System;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello FinalProject World!");
        bool stillActive = true;
        ScaleActiviy scaleAct = new ScaleActiviy();
        GetRandomNoteAvtivity randomeNoteAct = new GetRandomNoteAvtivity();
        while(stillActive)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Music Therory Program");
            Console.WriteLine();
            Console.WriteLine("Chooses an option 1-3");
            Console.WriteLine("1. Scale Activity");
            Console.WriteLine("2. Random Note Activity");
            Console.WriteLine("3. Quit");
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                {
                    Console.Clear();
                    scaleAct.StartActivity();
                    break;
                }
                case "2":
                {
                    Console.Clear();
                    randomeNoteAct.StartActivity();
                    break;
                }
                case "3":
                {  
                    stillActive = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("That is not a valid input!");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
    }
}