public class Assignment
{
    
    protected string _studentName;
    protected string _topic;

    public string GetSummary()
    {
        string summary = $"{_studentName}, {_topic}";

        return  summary;   
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
}