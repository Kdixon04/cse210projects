class ChecklistGoal : BaseGoal
{

    private int _numberOfCompletions;
    

    public ChecklistGoal(string name, string description, int points, bool complete, string goalType)
     : base (name, description, points, complete, goalType)
    {
        
    }

    public override int RecordEvent()
    {
        return 0;
    }
}