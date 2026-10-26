class Assignment
{
    
    private string _studentName;
    private string _topic;

    public string GetSummary()
    {
        _studentName = "Samuel Bennet";
        _topic = "Multiplication";

        string summary = $"{_studentName}, {_topic}";

        return  summary;   
    }
}