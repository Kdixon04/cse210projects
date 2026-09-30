using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberAppend = 1;
        int sum = 0;

        while (numberAppend != 0)
        {
            Console.Write("Enter numbers into a list (Press 0 when done):");
            string response = Console.ReadLine();
            numberAppend = int.Parse(response);    
            
            if (numberAppend != 0)
            {
              numbers.Add(numberAppend);  
            }
        
        foreach (int number in numbers)
            {
                sum += number;
            }
        
        float mean = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {mean}");

        int max = numbers[0];

        foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
        Console.WriteLine($"Max:{max}");
        }
        
        
    }
}