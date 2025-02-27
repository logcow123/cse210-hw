class ReflectionActivity : Activity
{
    private List<string> _questionList;
    private List<string> _promptList;
    private Random _myRand;

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _questionList = ["Why was this experience meaningful to you?",
                         "Have you ever done anything like this before?",
                         "How did you get started?",
                         "How did you feel when it was complete?",
                         "What made this time different than other times when you were not as successful?",
                         "What is your favorite thing about this experience?",
                         "What could you learn from this experience that applies to other situations?",
                         "What did you learn about yourself through this experience?",
                         "How can you keep this experience in mind in the future?"];

        _promptList = ["Think of a time when you stood up for someone else.",
                       "Think of a time when you did something really difficult.",
                       "Think of a time when you helped someone in need.",
                       "Think of a time when you did something truly selfless."];
        _myRand = new Random();
    }

    public void ReflectionLoop()
    {
        int indexPrompt = _myRand.Next(_promptList.Count());
        Console.WriteLine($"-- {_promptList[indexPrompt]} --");
        Console.WriteLine();
        Console.WriteLine("Press 'Enter' to Continue ");
        Console.ReadLine();
        Console.WriteLine("Get Ready...");
        theLoader.load(5);
        Console.Clear();
        _mainTimer.StartTimer();
        while(_mainTimer.IsDone() == false)
        {
            int indexQuest = _myRand.Next(_questionList.Count());
            Console.WriteLine(_questionList[indexQuest]);
            theLoader.load(_mainTimer.getDuration()/4);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"Congratulations! you completed the reflection activity for {_mainTimer.getDuration()} Seconds!");
        Console.WriteLine();
        Console.WriteLine("Press 'Enter' to continue");
        Console.ReadLine();
    }
}