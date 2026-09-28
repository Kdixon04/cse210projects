using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            Console.Write("Do you want to play a game? ");
            response = Console.ReadLine(); 
        } while (response == "yes");
        int guess;

        Console.Write("Guess a number that I am thinking of (1-100): ");
        guess = Console.Read();

    }
}