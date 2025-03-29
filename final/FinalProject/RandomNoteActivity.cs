class GetRandomNoteAvtivity : Activity
{
    Scale myScale;
    public GetRandomNoteAvtivity() : base("Random Note", "Try to Play the Note Before it Switches!")
    {
        myScale = new Scale();
    }
    public override void StartActivity()
    {
        int numOfNotes = 0;
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_startMsg);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session: ");
        SetDuration(double.Parse(Console.ReadLine()));
        _mainTimer.StartTimer();
        while(_mainTimer.IsDone() == false)
        {
            Console.WriteLine(myScale.GetRandomNoteAll());
            Console.ReadLine();
            numOfNotes++;
            Console.Clear();
        }
        Console.WriteLine("Congratulations!");
        Console.WriteLine($"You played {numOfNotes} Notes in {_mainTimer.getDuration()} Seconds!");
        Console.WriteLine($"You Averaged {Math.Round(numOfNotes/_mainTimer.getDuration(), 2)} Notes per Second");
        Console.WriteLine();
        Console.WriteLine("Press -ENTER- to continue");
        Console.ReadLine();
    }
}