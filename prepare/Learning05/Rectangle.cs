using System.Reflection.Metadata.Ecma335;

class Rectangle : Shape
{

    private double _side;

    public Rectangle(string color, double side) : base (color)
    {
        _side = side;    
    }
}