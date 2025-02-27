using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop04 World!");
        Loader myLoader = new Loader();
        BreathingActivity breathActivity = new BreathingActivity();
        ReflectionActivity reflectActivity = new ReflectionActivity();
       bool stillActive = true;
        string userChoice;

        myLoader.load(2);
        while(stillActive)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Mindfullness Program!");
            Console.WriteLine();
            Console.WriteLine("Chooses an option 1-4");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit");
            userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                {
                    myLoader.load(3);
                    Console.Clear();
                    breathActivity.StartActivity();
                    breathActivity.BreathLoop();
                    break;
                }
                case "2":
                {
                    myLoader.load(3);
                    Console.Clear();
                    reflectActivity.StartActivity();
                    reflectActivity.ReflectionLoop();
                    break;
                }
                case "3":
                {   
                    myLoader.load(3);
                    Console.Clear();
                    break;
                }
                case "4":
                {  
                    stillActive = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("That is not a valid input!");
                    myLoader.load(3);
                    break;
                }
            }
        }


    }
}