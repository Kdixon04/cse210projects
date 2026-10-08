class JournalEntry
// class should match name of file
{
    public string _date;
    public string _prompt;
    public string _response;



    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    // void = doesn't return anything
    public void CreateJournalEntry()
    {
        //List of prompts
        string[] prompts =
        {
            "How was your day?",
            "Talk about someone you met?"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts[0];
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }
}