class Cart
{
    //variables
    public string _name = "TBD";
    public List<Item> _items = new List<Item>();

    //methods
    public void Display()
    {
        Console.WriteLine($"Welcome to {_name}");

        foreach (var item in _items)
        {
            item.Display();
        }
    }
    
    public void Add()
    {
        Item newItem = new Item();

        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();
        newItem._name = name;

        Console.Write("Enter Item Price: ");
        string amount = Console.ReadLine();
        newItem._amount = double.Parse(amount);

        _items.Add(newItem);
    }

    public double CalcTotal()
    {
        double total = 0;

        foreach (var item in _items)
        {
            total += item._amount;
        }

        return total;
    }
}