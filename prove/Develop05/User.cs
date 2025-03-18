using System.Text.Json.Serialization;

class User
{
    private List<Goal> _userGoals;
    private int _totalPoints;

    public User()
    {
        _userGoals = new List<Goal>();
        _totalPoints = 0;
    }

    public User(List<Goal> goals, int points)
    {
        _userGoals = goals;
        _totalPoints = points;
    }

    public void CreateGoal(string choice, string name, string desc, int worth)
    {
        switch(choice)
        {
            case "1":
            {
                _userGoals.Add(new SimpleGoal(name, desc, worth));
                break;
            }
            case "2":
            {
                Console.WriteLine("How Many Times Do you want until you complete this Goal?");
                int timesToComplete = int.Parse(Console.ReadLine());
                Console.WriteLine("How Much will it be worth when you complete the Goal?");
                int worth2 = int.Parse(Console.ReadLine());
                _userGoals.Add(new CheckListGoal(name, desc, worth, timesToComplete, worth2));
                break;
            }
            case "3":
            {
                _userGoals.Add(new EternalGoal(name, desc, worth));
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        int i = 0;
        Console.Clear();
        foreach(Goal myGoal in _userGoals)
        {
            i++;
            Console.Write($"{i}) ");
            myGoal.Display();
        }
        Console.WriteLine();
        Console.WriteLine($"Points: {_totalPoints}");
    }

    public void CheckOffGoal(int index)
    {
        _totalPoints = _totalPoints + _userGoals[index].AwardGoal();
    }

    public List<Goal> getGoals()
    {
        return _userGoals;
    }

    public void saveGoals()
    {
        string fileName = "myGoals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Points, {_totalPoints}");
            foreach (Goal theGoal in _userGoals)
            {
                outputFile.WriteLine(theGoal.OutputData());
            }
        }
    }

    public void loadGoals()
    {
        string filename = "myGoals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");

            string goalType = parts[0];
            switch(goalType)
            {
                case "Points":
                {
                    _totalPoints = int.Parse(parts[1]);
                    break;
                }
                case "Simple":
                {
                    string goalName = parts[1];
                    string goalDesc = parts[2];
                    int goalWorth = int.Parse(parts[3]);
                    bool goalComplete = bool.Parse(parts[4]);
                    _userGoals.Add(new SimpleGoal(goalName, goalDesc, goalWorth, goalComplete));
                    break;
                }
                case "Eternal":
                {
                    string goalName = parts[1];
                    string goalDesc = parts[2];
                    int goalWorth = int.Parse(parts[3]);
                    bool goalComplete = bool.Parse(parts[4]);
                    _userGoals.Add(new EternalGoal(goalName, goalDesc, goalWorth, goalComplete));
                    break;
                }
                case "Check":
                {
                    string goalName = parts[1];
                    string goalDesc = parts[2];
                    int goalWorth = int.Parse(parts[3]);
                    bool goalComplete = bool.Parse(parts[4]);
                    int goalTimesToComplete = int.Parse(parts[5]);
                    int goalTimesCompleted = int.Parse(parts[6]);
                    int goalWorthOnCompletion = int.Parse(parts[7]);
                    _userGoals.Add(new CheckListGoal(goalName, goalDesc, goalWorth, goalComplete, goalTimesToComplete, goalTimesCompleted, goalWorthOnCompletion));
                    break;
                }
            }
        }
    }
}