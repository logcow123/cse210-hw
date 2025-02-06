class Word
{
    private string _word = "";
    private bool _isHidden = false;
    
    public void SetHidden(bool boolHidden)
    {
        _isHidden = boolHidden;
    }
    public void SetWord(string wordString)
    {
        _word = wordString;
    }

    public string GetWord()
    {
        if(_isHidden)
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