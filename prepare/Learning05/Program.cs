using System;

class Program
{
    static void Main(string[] args)
    {
        //Displays the message, "Welcome to the Program!"//
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //Asks for and returns the user's name//
        static string PromptUserName()
        {
            Console.Write("What is your name?: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What year were you born?: ");
            birthYear = int.Parse(Console.ReadLine());
            return birthYear;
        }

        static int SquareNumber(int userNumber)
        {
            int numberSquared = userNumber * userNumber;
            return numberSquared;
        }

        // static string DisplayResults(string userName, int numberSquared,)
        // {

        // }

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        

    }
}