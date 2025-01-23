class Job
{
    // variables
    public string _jobTitle = "";
    public string _companyName = "";
    public int _startDate = 0;
    public int _endDate = 0;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate}-{_endDate}");
    }

}