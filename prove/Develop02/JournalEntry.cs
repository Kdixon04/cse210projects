class JournalEntry
// class should match name of file
{
    private string _date;
    private string _prompt;
    private string _response;

    

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
            "Talk about someone you met?",
            "How did you grow today?",
            "What are you grateful for today?",
            "When did you experience growth today?"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts[0];
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }

    public void CreateEntry()
    {
        string journalEntry
    }

    public void CreateEntryWithData(string date, string prompt, string response)
    {
        this._date = date;
        this._entryQuestion = prompt;
        this._journalEntry = response;
    }
}