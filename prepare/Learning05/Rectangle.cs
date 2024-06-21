

public class Rectangle : Shape
{
    private double _length;
    private double _wdith;

    public Rectangle(string color, double legnth, double width) : base (color)
    {
        _length = legnth;
        _wdith = width;
    }

    public override double GetArea()
    {
        return _length * _wdith;
    }

}