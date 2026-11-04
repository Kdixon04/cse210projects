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

        Console.WriteLine($"Fraction 3 Top {fraction3.GetTop()}");
        Console.WriteLine($"Fraction 3 Bottom: {fraction3.GetBottom()}");

        Console.WriteLine("New Fraction 3: ");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Random random = new Random();
        // Random addition
        for (int i = 0; i < 20; i++){
            
            fraction_1.SetTop(random.Next(1, 11));
            fraction_1.SetBottom(random.Next(1, 11));

            Console.WriteLine($"Fraction {i + 1}: string: {fraction_1.GetFractionString()} Number: {fraction_1.GetDecimalValue()}");
        }
    }
}