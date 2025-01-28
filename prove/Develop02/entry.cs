
class Entry
{
    public string _prompt = "";
    public string _entry = "";
    public string _date = DateTime.Today.ToString("dd/MM/yyyy");
    public int _dayRating = 0;

    public void GeneratePrompt()
    {
        Random rnd = new Random();
        int prompt_num = rnd.Next(5);
        if(prompt_num == 0)
        {
            _prompt = "Would you rather have an unlimited supply of burgers or fries?";
        } else if(prompt_num == 1)
        {
            _prompt = "What is the first thing you are grabing if your house is burning?";
        } else if(prompt_num == 2)
        {
            _prompt = "Where is your faveorite place to eat out?";
        }else if(prompt_num == 3)
        {
            _prompt = "Who would win in a fight; Godzilla or King Kong?";
        }else if(prompt_num == 4)
        {
            _prompt = "Do you prefer salty or sweet foods?";
        }

        Console.WriteLine($"Generated Prompt: '{_prompt}'");
    }

    public void WriteEntry()
    {
        GeneratePrompt();

        Console.WriteLine();
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}: ");
        _entry = Console.ReadLine();
        Console.WriteLine();
        RateDay();

        Console.WriteLine("--Entry Recorded--");
    }

    public void RateDay()
    {
        Console.WriteLine("On a scale from [1 - 5] How would you rate your day?");
        _dayRating = int.Parse(Console.ReadLine());
    }
    public void ReadEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"Q: {_prompt}: ");
        Console.WriteLine();
        Console.WriteLine($"{_entry}");
        Console.WriteLine();
        Console.WriteLine($"Your Day Rating was: {_dayRating}");
    }
}