class ScaleActiviy : Activity
{
    // This class will be the main activity involving the scales.
    // It will present a random scale and you will need to guess the scale based on the notes
    // for example it will present: [C, D, E, F, G, A, B]
    // And you will have to say it's a 'C major' or an 'A Minor' scale
    Scale myScale;
    public ScaleActiviy() : base("Scale", "Try to find the key of the scale!")
    {
        myScale = new Scale();
    }

    private void GetRandomScale()
    {
        Random random = new Random();
        string scaleNote = myScale.GetRandomNoteAll();
        int intIsMajor = random.Next(2);
        bool isMajor;
        if(intIsMajor == 0)
        {
            isMajor = false;
        }else
        {
            isMajor = true;
        }
        myScale.ChangeKey(scaleNote, isMajor);
    }
    public override void StartActivity()
    {
        int numOfTries = 0;
        int scalesDone = 0;
        string userInput;
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_startMsg);
        Console.WriteLine();
        Console.Write("How many Scales would you like to try? ");
        int numOfScales = int.Parse(Console.ReadLine());
        while(numOfScales > scalesDone)
        {
            Console.Clear();
            GetRandomScale();
            Console.WriteLine("What Scale is This? (Ex: 'C Maj' / 'A Minor')");
            myScale.DisplayScale();
            userInput = Console.ReadLine();
            if(CheckKey(userInput))
            {
                scalesDone++;
                Console.WriteLine("CORRECT! :)");
            }else
            {
                Console.WriteLine("INCORRECT!");
            }
            numOfTries++;
            Console.WriteLine();
            Console.WriteLine("Press 'ENTER' to continue");
            Console.ReadLine();
        }
    }

    private List<string> ParseKey(string userInput)
    {
        List<string> keyAndMode = new List<string>();
        string note = "";
        string modeString = "";
        bool doneWithNote = false;
        foreach(char let in userInput)
        {
            if(doneWithNote)
            {
                modeString = modeString + let;
            }else
            {
                if(let != ' ')
                {
                    note = note + let;
                }else
                {
                    doneWithNote = true;
                }
            }
        }
        keyAndMode.Add(note);
        keyAndMode.Add(modeString);
        return keyAndMode;
    }

    private bool CheckKey(string userInput)
    {
        List<string> keyAndMode = ParseKey(userInput);
        string keyNote = keyAndMode[0].ToUpper();
        bool isMajor;
        string modeString = "";
        Scale userScale= new Scale();
        foreach(char let in keyAndMode[1])
        {
            modeString = modeString + let;
            if(modeString.Length == 3)
            {
                if(modeString.ToLower() == "maj")
                {
                    isMajor = true;
                }else
                {
                    isMajor = false;
                }
                userScale.ChangeKey(keyNote, isMajor);
                break;
            }
        }
        return myScale.IsSameScale(userScale.GetScale());
    }
}