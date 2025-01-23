using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Resume myResume = new Resume();
        Console.Write("Enter Your Name: ");
        myResume._name = Console.ReadLine();

        myResume.AddJob();
        myResume.AddJob();

        myResume.Display();
    }
}