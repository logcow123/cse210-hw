using System.Threading.Tasks.Dataflow;

class Verse
{
    private List<Word> _verseWords;

    public Verse(string verse)
    {
        _verseWords = new List<Word>(); // creates the list of words
        verse = verse + " ";            // if the string doesn't end with a space it will still get the last word
        string currentWord = "";  
        Word theWord;
        foreach(char let in verse)
        {
            if(let == ' ')          // When a space is detected it will create a word with the combined letters
            {
                if(currentWord != "")
                {
                    theWord = new Word(currentWord);
                    _verseWords.Add(theWord);
                }
                currentWord = "";
            }else                   // combines the letter with the previously combined letters
            {
                currentWord = currentWord + let;
            }
        }
    }

    public void DisplayVerse()
    {
        foreach(Word word in _verseWords)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
}
