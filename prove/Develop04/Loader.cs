using System.Diagnostics.SymbolStore;

class Loader
{
    private List<string> _loadSmbols = new List<string>();

    public Loader()
    {
        _loadSmbols = ["|", "\\", "-", "/"];
    }
    public void load(double sec)
    {
        double currentTime = 0;
        Console.Write("+");
        while(sec > currentTime)
        {
            foreach(string sym in _loadSmbols)
            {
                Thread.Sleep(125);
                Console.Write("\b \b"); // Erase the + character
                Console.Write(sym); // Replace it with a load character
                currentTime = currentTime + 0.125;
            }
        }
        Console.Write("\b \b");

    }
}