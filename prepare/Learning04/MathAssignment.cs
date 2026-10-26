public class MathAssignment : Assignment
{
    private string _textbookSection;
    
    private string _problems;

    public string GetHomeworkList()
    {
        string homework = $"{_textbookSection}{_problems}";
        return homework;
    }

    public MathAssignment (string studentName, string topic, string textBookSection, string problems) : base (studentName, topic)
    {
        _textbookSection = textBookSection;
        _problems = problems;
    }   

    
}