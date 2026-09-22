using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 30;
        int z = 40;

        // If an if statement has multiple lines of code, curly braces are necessary
        // If only one line is in an if statement, no need for curly braces
        // If you want the or (||) go first, put the && in parenthesis
        if ((x == 10 && y == 30) || z == 30)
        {
            Console.WriteLine("x is 10");
            Console.WriteLine("y is fun");
        }    
        else if (x == 20)
        {
            Console.WriteLine("x is 20");
        }
        else
        {
            Console.WriteLine("Default output");
        }
    }
}