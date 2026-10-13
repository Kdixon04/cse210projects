using System;
using System.Net;

class Program
{

    private static string ObtainFileName(string prompt)
    {
        
    }
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();


        int response = 0;

        myMenu.ProcessMenu();


        while (response != 5)
        {
            response = myMenu.ProcessMenu();
        // switch essentially is else if else if else if
            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    // Call CreateJournalEntry()
                    break;
                case 2:
                    Console.WriteLine();
                    myJournal.DisplayJournal();
                    Console.WriteLine();
                    // Console.WriteLine("Display");
                    // Call DisplayJournal()
                    break;
                case 3:
                
                    // Call ReadFromFile()
                    break;
                case 4:
                    Console.WriteLine("Write");
                    // call WritetoFile()
                    break;
        }
        }
    }
}