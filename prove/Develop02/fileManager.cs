using System.Text.Json;
class FileManager
{
    public void SaveJournal(Journal journal)
    {
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Journals");
        string filePath = Path.Combine(folderPath, $"Journals.json");
    
        // Create directory if it doesn't exist
        Directory.CreateDirectory(folderPath);

        string journalString = JsonSerializer.Serialize(journal);
        File.WriteAllText(filePath, journalString);
    }
}