using System.Diagnostics;

class Timer
{
    DateTime _futureTime;
    private double _duration;
    public Timer()
    {
        _duration = 5;
    }
    public Timer(double duration)
    {
        
        _duration = duration;
    }

    public double getDuration()
    {
        return _duration;
    }

    public void setDuration(double duration)
    {
        _duration = duration;
    }

    public void StartTimer()
    {
        _futureTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool IsDone()
    {
        if(_futureTime < DateTime.Now)
        {
            return true;
        }
        return false;
    }
}