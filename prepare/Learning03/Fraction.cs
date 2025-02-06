class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public void GetTop()
    {
        Console.WriteLine(_topNumber);
    }
    public void SetTop(int num)
    {
        _topNumber = num;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottomNumber);
    }
    public void SetBottom(int num)
    {
        _bottomNumber = num;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }
    public double GetDecimalValue()
    {
        return Convert.ToDouble(_topNumber)/_bottomNumber;
    }
}