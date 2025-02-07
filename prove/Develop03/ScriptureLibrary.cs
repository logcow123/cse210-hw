class ScriptureLibrary
{
    private List<Verse> _verseLibrary;

    public ScriptureLibrary()
    {
        _verseLibrary = new List<Verse>();

        Verse addVerse = new Verse("John 3:16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _verseLibrary.Add(addVerse);
        addVerse = new Verse("Proverbs 3:5-6","Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        _verseLibrary.Add(addVerse);
        addVerse = new Verse("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        _verseLibrary.Add(addVerse);
    }
    public void DisplayScriptures()     //Display all the scriptures
    {
        foreach(Verse ver in _verseLibrary)
        {
            ver.DisplayVerse();
        }
    }
    public Verse GetScripture()     // get a random scripture
    {
        Random rand = new Random();
        return _verseLibrary.ElementAt(rand.Next(_verseLibrary.Count()));
    }
}