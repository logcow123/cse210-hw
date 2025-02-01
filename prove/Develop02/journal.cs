using System.Text.Json.Serialization;

class Journal
{
    [JsonInclude]
    public string _name = "";
    [JsonInclude]
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void RemoveEntry(Entry entry)
    {
        _entries.Remove(entry);
    }

    public Entry GetEntry(int index)
    {
        return _entries.ElementAt(index);
    }

    public void DisplayEntries()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine("========================================");
            entry.ReadEntry();
        }
    }
    public void JournalName(string name)
    {
        _name = name;
    }
}
