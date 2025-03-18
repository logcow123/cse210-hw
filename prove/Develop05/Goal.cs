using System.Text.Json.Serialization;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _worth;
    protected bool _isCompleted;

    public Goal()
    {
        _name = "";
        _description = "N/A";
        _worth = 0;
        _isCompleted = false;
    }

    public Goal(string name, string desc, int worth)
    {
        _name = name;
        _description = desc;
        _worth = worth;
        _isCompleted = false;
    }
    public Goal(string name, string desc, int worth, bool isComplete)
    {
        _name = name;
        _description = desc;
        _worth = worth;
        _isCompleted = isComplete;
    }

    public virtual void Display()
    {
        if(_isCompleted)
        {
            Console.Write("[X] ");
        }else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_name} ({_description})");
    }

    public abstract int AwardGoal();
    public abstract string OutputData();
    
}