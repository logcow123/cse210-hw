using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please Enter your Score!");
        int score = int.Parse(Console.ReadLine());
        string letterGrade;

        if(score >= 90)
        {
            letterGrade = "A";
        } else if(score >= 80)
        {
            letterGrade = "B";
        } else if(score >= 70)
        {
            letterGrade = "C";
        } else if(score >= 60)
        {
            letterGrade = "D";
        } else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your Grade is a {letterGrade}");
    }

}