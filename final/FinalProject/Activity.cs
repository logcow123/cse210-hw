abstract class Activity
{
    protected Timer _mainTimer = new Timer();
    protected string _startMsg;
    protected string _activityName;
    
    public Activity()
    {
        _mainTimer.setDuration(20);
        _startMsg = "N/A";
    }

    public Activity(string name , string startMsg)
    {
        _mainTimer = new Timer();
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
    abstract public void StartActivity();
}