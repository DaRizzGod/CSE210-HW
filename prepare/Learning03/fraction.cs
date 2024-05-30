class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
       _top = wholeNumber;
       _bottom = 1; 
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for _top
    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    // Getter and Setter for _bottom
    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
