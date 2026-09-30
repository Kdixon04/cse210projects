using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberAppend = 1;

        while (numberAppend != 0)
        {
            Console.Write("Enter numbers into a list (Press 0 when done):");
            string response = Console.ReadLine();
            numberAppend = int.Parse(response);    
            
        }
        else
        {
            
        }
        
    }
}