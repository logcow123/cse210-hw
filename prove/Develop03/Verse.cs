using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Verse
{
    private Reference _verseReference;
    private List<Word> _verseWords;

    public Verse(string verse)
    {
        _verseReference = new Reference();
        ParseVerse(verse);
    }
    public Verse(string reference, string verse)
    {
        _verseReference = new Reference(reference);
        ParseVerse(verse);
    }
    private void ParseVerse(string verse)
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
    public bool CheckAllHidden()
    {
        bool allHidden = true;              //This seems backwards but... This checks all the words and if it finds
        foreach(Word word in _verseWords)   //at least one word that is not hidden it will return false
        {
            if(word.GetHidden() == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
    public void DisplayVerse()
    {
        Console.WriteLine(_verseReference.GetFullReference());
        foreach(Word word in _verseWords)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }
}
