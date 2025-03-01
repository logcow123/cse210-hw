class ListingActivity : Activity
{
    private List<string> _proptList;
    private int _numOfThings;
    private Random _myRand;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _proptList = ["Who are people that you appreciate?",
                      "What are personal strengths of yours?",
                      "Who are people that you have helped this week?",
                      "When have you felt the Holy Ghost this month?",
                      "Who are some of your personal heroes?"];
        _numOfThings = 0;
        _myRand = new Random();
    }

    public int GetNumOfThings()
    {
        return _numOfThings;
    }

    public void ListLoop()
    {
        _numOfThings = 0;
        int beginTimer = 5;
        Console.WriteLine("List any many things that come to mind when you read the question: ");
        Console.WriteLine($"-- {_proptList[_myRand.Next(_proptList.Count())]} --");
        Console.WriteLine();
        Console.Write("You May Begin in: ");
        while(beginTimer > 0)
        {
            Console.Write(beginTimer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            beginTimer = beginTimer - 1;
        }
        Console.WriteLine();
        _mainTimer.StartTimer();
        while(_mainTimer.IsDone() == false)
        {
            Console.Write("> ");
            Console.ReadLine();
            _numOfThings++;
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"You completed the activity for {_mainTimer.getDuration()} Seconds!");
        Console.WriteLine($"You Listed {_numOfThings} things!");
        Console.WriteLine();
        Console.WriteLine("Press 'Enter' to continue");
        Console.ReadLine();
    }
}