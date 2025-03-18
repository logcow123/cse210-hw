public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int worth, bool isComplete) : base(name, desc, worth, isComplete)
    {
        
    }

    public EternalGoal(string name, string desc, int worth) : base(name, desc, worth)
    {

    }

    public override int AwardGoal()
    {
       return _worth;
    }
    public override string OutputData()
    {
        string data = $"Eternal, {_name}, {_description}, {_worth}, {_isCompleted}";
        return data;
    }
}