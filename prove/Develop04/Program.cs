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
        ListingActivity listActivity = new ListingActivity();
        double secBreath = 0;
        double secReflect = 0;
        double secList = 0;
        int totalThings = 0;
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
            Console.WriteLine("4. View my Stats");
            Console.WriteLine("5. Quit");
            userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "1":
                {
                    myLoader.load(3);
                    Console.Clear();
                    breathActivity.StartActivity();
                    breathActivity.BreathLoop();
                    secBreath = secBreath + breathActivity.Duration();
                    break;
                }
                case "2":
                {
                    myLoader.load(3);
                    Console.Clear();
                    reflectActivity.StartActivity();
                    reflectActivity.ReflectionLoop();
                    secReflect = secReflect + reflectActivity.Duration();
                    break;
                }
                case "3":
                {   
                    myLoader.load(3);
                    Console.Clear();
                    listActivity.StartActivity();
                    listActivity.ListLoop();
                    secList = secList + listActivity.Duration();
                    totalThings = totalThings + listActivity.GetNumOfThings();
                    break;
                }
                case "4":
                {
                    myLoader.load(1);
                    Console.Clear();
                    Console.WriteLine("Seconds Spent In Activities: ");
                    Console.WriteLine();
                    Console.WriteLine($"Breathing Activity: {secBreath}");
                    Console.WriteLine($"Reflection Activity: {secReflect}");
                    Console.WriteLine($"Listing Activity: {secList}");
                    Console.WriteLine();
                    Console.WriteLine($"Total Seconds: {secBreath + secList + secReflect}");
                    Console.WriteLine();
                    Console.WriteLine($"Number Of Things Listed: {totalThings}");
                    Console.WriteLine();
                    if((secBreath > secList) && (secBreath > secReflect))
                    {
                        Console.WriteLine("Your Favorite Activity was the Breathing Activity! ");
                    }else if((secList > secBreath) && (secList > secReflect))
                    {
                        Console.WriteLine("Your Favorite Activity was the Listing Activity");
                    }else if((secReflect > secBreath) && (secReflect > secList))
                    {
                        Console.WriteLine("Your Favorite Activity was the Reflection Acctivity!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press 'Enter' To Contine");
                    Console.Read();
                    break;
                }
                case "5":
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