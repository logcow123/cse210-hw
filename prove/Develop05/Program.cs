using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        User myUser = new User();
        bool programRunning = true;
        string userInput;

        while(programRunning)
        {
            Console.Clear();
            Console.WriteLine("Please Choose an option:");
            Console.WriteLine("1) Create Goal");
            Console.WriteLine("2) List Goals");
            Console.WriteLine("3) Complete Goal");
            Console.WriteLine("4) Save Goals");
            Console.WriteLine("5) Load Goals");
            Console.WriteLine("6) Quit");
            userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                {
                    Console.Clear();
                    Console.WriteLine("What Goal would you like?");
                    Console.WriteLine("1) Simple Goal");
                    Console.WriteLine("2) List Goal");
                    Console.WriteLine("3) Eternal Goal");
                    string goalChoice = Console.ReadLine();
                    Console.WriteLine("What is the name of your goal?");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Describe your goal");
                    string goalDesc = Console.ReadLine();
                    Console.WriteLine("How much is your goal worth?");
                    int goalWorth = int.Parse(Console.ReadLine());
                    myUser.CreateGoal(goalChoice, goalName, goalDesc, goalWorth);
                    break;
                }
                case "2":
                {
                    Console.Clear();
                    myUser.DisplayGoals();
                    Console.WriteLine();
                    Console.WriteLine("Press 'ENTER' to continue");
                    Console.ReadLine();
                    break;
                }
                case "3":
                {
                    Console.Clear();
                    Console.WriteLine("Which Goal would you like to complete?");
                    int completeGoalChoice = int.Parse(Console.ReadLine()) - 1;
                    myUser.CheckOffGoal(completeGoalChoice);
                    break;
                }
                case "4":
                {
                    myUser.saveGoals();
                    break;
                }
                case "5":
                {
                    myUser.loadGoals();
                    break;
                }
                case "6":
                {
                    programRunning = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Choice! press 'ENTER to continue'");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
    static void LoadFile()
    {

    }
}