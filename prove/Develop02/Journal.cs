using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void CreateJournalEntry()
    {
        
    }
    
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputfile.WriteLine(entry.ToString());
            }
        }
    }
    string filename = "Program.cs";

    public void ReadFromFile(string filename)
    {
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string _date = parts[0];
            string _entryQuestion = parts[1];
            string _entryText = parts[2];

            JournalEntry entry = new JournalEntry();
            entry.CreateEntryWithData(_date, _entryQuestion, _entryText);
            _entries.Add(entry);
        }
    }
     public override string ToString(_date, _entryQuestion, _journalEntry)
    {
        string outputString = "";
        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
        
        return outputString;
    }

}