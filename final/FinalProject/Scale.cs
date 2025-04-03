class Scale
{
    private List<string> _notes;
    private List<int> _scaleShift;
    private string _key;

    public Scale()
    {
        _notes = ["A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"];
        _scaleShift = [0, 2, 2, 1, 2, 2, 2];
        _key = "C";
    }

    public Scale(string key, bool isMajor)
    {
        _notes = ["A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"];
        if(isMajor)
        {
            _scaleShift = [0, 2, 2, 1, 2, 2, 2];
        }else
        {
            _scaleShift = [0, 2, 1, 2, 2, 1, 2];
        }
        _key = key;
    }

    public List<string> GetScale()
    {
        List<string> scale = new List<string>();
        int start_index = _notes.FindIndex(f => f == _key);
        foreach(int count in _scaleShift)
        {
            start_index = (start_index + count) % 12;
            // 4(C) + 2 = 6(D) + 2 = 8(E) + 1 = 9(F) + 2 = 11(G) + 2 = 1(A) + 2 = 3(B) + 1 = 4(C)
            scale.Add(_notes[start_index]);
        }
        return scale;
    }

    public void DisplayScale()
    {
        foreach(string note in GetScale())
        {
            Console.Write(note);
            Console.Write(" ");
        }
        Console.Write("\n");
    }

    public string GetRandomNoteAll()
    {
        Random random = new Random();
        return _notes[random.Next(_notes.Count())];
    }

    public string GetRandomNoteScale()
    {
        Random random = new Random();
        List<string> myscale = GetScale();
        return myscale[random.Next(myscale.Count())];
    }

    public void ChangeKey(string key, bool isMajor)
    {
        if(isMajor)
        {
            _scaleShift = [0, 2, 2, 1, 2, 2, 2];
        }else
        {
            _scaleShift = [0, 2, 1, 2, 2, 1, 2];
        }
        _key = key;
    }

    public bool IsSameScale(List<string> notesInScale)
    {
        bool isSameScale;
        foreach(string outsideNote in notesInScale)
        {
            isSameScale = false;
            foreach(string insideNote in GetScale())
            {
                if(outsideNote == insideNote)
                {
                    isSameScale = true;
                }
            }
            if(isSameScale == false)
            {
                return false;
            }
        }
        return true;
    }
}