public class WritingAssignment : Assignment 
{
    
    private string _title;

    public string GetWritingAssignment()
    {
        string writingHomework = $"{_studentName} - {_topic}\n{_title} by {_studentName}";

        return writingHomework;
    }

    public WritingAssignment(string studentName, string topic, string title) : base (studentName, topic)
    {
        _title = title;
    }
}