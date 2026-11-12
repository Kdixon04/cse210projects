using System.Reflection.Metadata.Ecma335;

class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;

    }

    public override double GetArea()
    {
        return Math.Round((Math.PI * _radius), 2);
    }
}