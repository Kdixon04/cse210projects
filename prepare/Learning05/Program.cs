using System;

class Program
{
    static void Main(string[] args)
    {
     Square square = new Square("red", 7.5);   

     Console.WriteLine(square.GetColor());
     Console.WriteLine(square.GetArea());

     Rectangle rectangle = new Rectangle("blue", 9.5);
     Console.WriteLine(rectangle.GetColor());
     Console.WriteLine(rectangle.GetArea());

     Circle circle = new Circle("Green", 2);
     Console.WriteLine(circle.GetColor());
     Console.WriteLine(circle.GetArea());

    }
}