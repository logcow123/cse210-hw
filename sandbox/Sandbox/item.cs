class Item
{
    // variables
    public string _name = "";
    public double _amount = 0.00;
    public bool _checked = false;

    //methods
    public void Display()
    {
        Console.WriteLine($"{_name}, {_amount}, {_checked}");
    }
}