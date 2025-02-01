using System.Text.Json;
class FileManager
{
    public void SaveJournal(Journal journal)
    {
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Journals");
        string filePath = Path.Combine(folderPath, $"{journal._name}journal.json");
    
        // Create directory if it doesn't exist
        Directory.CreateDirectory(folderPath);

        string journalString = JsonSerializer.Serialize(journal);
        File.WriteAllText(filePath, journalString);
    }

    public Journal LoadJournal(string journalName)
    {
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Journals");
        string filePath = Path.Combine(folderPath, $"{journalName}journal.json");

        string jsonString = File.ReadAllText(filePath);
        Journal journal = JsonSerializer.Deserialize<Journal>(jsonString);
        return journal;
    }
}