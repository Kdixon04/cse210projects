using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        string guess;

        
            // Initiate the Game 
            Console.Write("Do you want to play a game? ");
            response = Console.ReadLine();
            // if user accept the game 
        if (response == "yes")
        {
            // generate a random number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, 11);
            Console.WriteLine(number);

            // ask the user to guess   
            Console.WriteLine("Guess a number that I am thinking of (1-10): ");
            guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);
        
        while (guessNumber != number)
            {
                if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            }
        }    
        else
        {
            Console.WriteLine("Have a great day");
        }
    }
}