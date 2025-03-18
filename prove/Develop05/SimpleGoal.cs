public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string desc, int worth, bool isComplete) : base(name, desc, worth, isComplete)
    {
        
    }
    public SimpleGoal(string name, string desc, int worth) : base(name, desc, worth)
    {

    }
    public override int AwardGoal()
    {
        if(_isCompleted == false)
            {
                _isCompleted = true;
                return _worth;
            }else
            {
                return 0;
            }
        
    }

    public override string OutputData()
    {
        string data = $"Simple, {_name}, {_description}, {_worth}, {_isCompleted}";
        return data;
    }
}