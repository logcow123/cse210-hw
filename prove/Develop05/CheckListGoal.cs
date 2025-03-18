using System.Text.Json.Serialization;

public class CheckListGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _worthForCompletion;

    public CheckListGoal(string name, string desc, int worth, bool isComplete, int timesToCompleteGoal, int timesCompleted,int worth2) : base(name, desc, worth, isComplete)
    {
        _timesToComplete = timesToCompleteGoal;
        _timesCompleted= timesCompleted;
        _worthForCompletion = worth2;
    }
    public CheckListGoal(string name, string desc, int worth, int timesToCompleteGoal, int worth2) : base(name, desc, worth)
    {
        _timesToComplete = timesToCompleteGoal;
        _timesCompleted= 0;
        _worthForCompletion = worth2;
    }

    public override int AwardGoal()
    {
        if(_isCompleted == false)
            {
                if (_timesCompleted == _timesToComplete)
                {
                    _isCompleted = true;
                    return _worthForCompletion;
                }
                _timesCompleted++;
                return _worth;
            }else
            {
                return 0;
            }
    }
    public override void Display()
    {
        if(_isCompleted)
        {
            Console.Write("[X] ");
        }else
        {
            Console.Write("[ ] ");
        }
        Console.Write($"{_name} ({_description}) ");
        Console.WriteLine($"[{_timesCompleted} / {_timesToComplete}]");
    }

    public override string OutputData()
    {
        string data = $"Check, {_name}, {_description}, {_worth}, {_isCompleted}, {_timesToComplete}, {_timesCompleted}, {_worthForCompletion}";
        return data;
    }
}