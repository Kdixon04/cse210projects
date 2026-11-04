using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction_1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        Console.Write("Fraction 1: ");
        Console.WriteLine(fraction_1.GetFractionString());
        Console.WriteLine(fraction_1.GetDecimalValue());

        Console.Write("Fraction 2: ");
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.Write("Fraction 3: ");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.Write("Fraction 4: ");
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        fraction3.SetTop(9);
        fraction3.SetBottom(6);

        Console.WriteLine("New Fraction 3: ");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}