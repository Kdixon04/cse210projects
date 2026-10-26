using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment myAssignment = new Assignment();
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        // myAssignment.GetSummary();
        // Console.WriteLine(myAssignment.GetSummary());

    }
}