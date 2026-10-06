using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = myMenu.ProcessMenu();

        // switch essentially is else if else if else if
        switch (response)
        {
            case 1:
                Console.WriteLine("Create");
                // Call CreateJournalEntry()
            break;
            case 2:
                Console.WriteLine("Display");
                // Call DisplayJournal()
            break;
            case 3:
                Console.WriteLine("Save");
                // Call ReadFromFile()
            break;
            case 4:
                Console.WriteLine("Write");
                // call WritetoFile()
            break;
        }
    }
}