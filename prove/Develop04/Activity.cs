class Activity
{
    protected Timer _mainTimer = new Timer();
    private string _startMsg;
    private string _activityName;
    protected Loader theLoader = new Loader();
    
    public Activity()
    {
        _mainTimer.setDuration(20);
        _startMsg = "N/A";

    }

    public Activity(string name , string startMsg)
    {
        _mainTimer = new Timer();
        theLoader = new Loader();
        _activityName = name;
        _startMsg = startMsg;
    }

    public void SetDuration(double duration)
    {
        _mainTimer.setDuration(duration);
    }
    public double Duration()
    {
        return _mainTimer.getDuration();
    }
    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_startMsg);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session: ");
        SetDuration(double.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine("Get Ready...");
        theLoader.load(5);
        Console.WriteLine();
    }
}