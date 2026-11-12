
using System.Drawing;

abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        _color = color;

    }

    public virtual double GetArea()
    {
        // Temporary Placeholder for now
        return 2.55;
    }
    
}