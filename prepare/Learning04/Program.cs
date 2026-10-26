using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment myAssignment = new Assignment();
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssigment = new WritingAssignment("The Causes of World War II", "European History", "Mary Waters");
        Console.WriteLine(writingAssigment.GetWritingAssignment());
        // myAssignment.GetSummary();
        // Console.WriteLine(myAssignment.GetSummary());

    }
}