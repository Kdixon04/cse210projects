using System;

class Program
{
    static void Main(string[] args)
    {
        World myWord = new World("Secret");

        myWord.Display();
        myWord.Hide();
        Console.WriteLine();
        myWord.Display();

    }
}