class Resume
{
    // variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void AddJob()
    {
        Job newJob = new Job();

        Console.Write("Enter Job Title: ");
        string Title = Console.ReadLine();
        newJob._jobTitle = Title;

        Console.Write("Enter Company Name: ");
        string company = Console.ReadLine();
        newJob._companyName = company;

        Console.Write("Enter Start Year: ");
        string startYear = Console.ReadLine();
        newJob._startDate = int.Parse(startYear);

        Console.Write("Enter End Year: ");
        string endYear = Console.ReadLine();
        newJob._endDate = int.Parse(endYear);

        _jobs.Add(newJob);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}