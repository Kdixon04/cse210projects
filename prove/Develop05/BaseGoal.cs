class BaseGoal
{
    private string _name;
    
    private string _description;

    public BaseGoal()
    {
        SetName();
        SetDescription();
    }

    private void SetName()
    {
        Console.WriteLine("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.WriteLine("What is the description of the goal: ");
        _description = Console.ReadLine();   
    }

    public virtual string GetConsoleString()
    {
        return $"[] Goal Name: {_name}; {_description}";
    }
}