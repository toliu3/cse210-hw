public class Retangle : Shape
{
    private double _length;
    private double _width;

    public Retangle( string color, double Length, double width) : base(color)
    {
        _length = Length;
        _width = width;
    }

    public override double GetArae()
    {
        double area = _length * _width;
        return area;
    }

}