using System.Collections.Concurrent;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = -1;
    }
    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
    }
    public Reference()
    {
        _book = "Not Declared";
        _chapter = -1;
        _verse = -1;
        _verseEnd = -1;
    }

    public void ParseReferefce(string referenceString) // This expects a string as such: "Proverbs 5:5-6" or "John 3:16" and save it in the reference
    {
        referenceString = referenceString + "%";        //This is an ending character to find the last number of the string
        string parseString = "";                        // this will be set to the book, chapter, and verses as a string
        bool hasMultiple = false;                       // this will determine if the string has multiple verses
        foreach(char let in referenceString)
        {  
            if(let == ' ')                              
            {
                _book = parseString;
                parseString = "";
            }else if(let == ':')
            {
                _chapter = int.Parse(parseString);
                parseString = "";
            }else if(let == '-')
            {
                _verse = int.Parse(parseString);
                hasMultiple = true;
                parseString = "";
            }else if(let == '%')
            {
                if(hasMultiple)
                {
                    _verseEnd = int.Parse(parseString);
                }else
                {
                    _verseEnd = -1;                     // if there are no multiple verse it changes verse end back to -1
                    _verse = int.Parse(parseString);
                }
            }else
            {
                parseString = parseString + let;
            }
            
        }
    }
    public string GetFullReference()
    {
        if(_verseEnd > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}