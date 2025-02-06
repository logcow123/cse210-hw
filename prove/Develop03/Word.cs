class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string theWord, bool isHidden) //The Constructors
    {
        _word = theWord;
        _isHidden = isHidden;
    }
    public Word(string theWord)
    {
        _word = theWord;
        _isHidden = false;
    }
    public Word()
    {
        _word = "_NULL_";
        _isHidden = false;
    }
    
    public void SetHidden(bool boolHidden)
    {
        _isHidden = boolHidden;
    }
    public void SetWord(string wordString)
    {
        _word = wordString;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }
    public string GetWord()
    {
        if(_isHidden)           //checks if word is hidden, if so it will convert the string to a string of underscores
        {
            string hiddenWord = "";
            foreach(char let in _word)
            {
                hiddenWord = hiddenWord + "_";
            }
            return hiddenWord;
        }else
        {
            return _word;
        }
    }
}