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

    public void HideWords(int numOfHidden)          //This will take some explaining
    {                                               //This class takes in an interger and hides that many number of words
        Random rand = new Random();
        int myrandom = -1;
        while(numOfHidden > 0)                      //This loops until all the words are hidden that can be
        {
            bool stillWorking = false;              //This will stop an infinate loop if all the words are hidden while numOfHidden > 0(Line 89)
            foreach(Word word in _verseWords)       //Itterates through the list of words
            {
                if(word.GetHidden() == false)       //If an unhidden word is found it will tell the program it's still working and determine if will be hidden
                {
                    stillWorking = true;
                    myrandom = rand.Next(5);
                    if(myrandom == 1)               //Gets a random int between 0 and 4 and if it's 1 it will hide the word and subtract from the numOfHidden count
                    {
                        word.SetHidden(true);
                        numOfHidden = numOfHidden - 1;
                        if(numOfHidden == 0)        //If the count reaches 0 it will break the loop
                        {
                            break;
                        }

                    }
                }
            }
            if(stillWorking == false)               //see line 70
            {
                break;
            }
        }
    }
}
