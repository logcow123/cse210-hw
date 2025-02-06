using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction myFraction = new Fraction();

        myFraction.SetTop(1);
        myFraction.SetBottom(3);

        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
    }
}