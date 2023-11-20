public class Goal
{
    // Figure if the class can be abstract instead.
    protected string _goalName;
    protected string _goalDescription;
    protected int _basePoints;
    
    // Find protection level.
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _basePoints = points;
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine("HEHEHE, Goal goes brbrbrbrb.");
    }

    public virtual string GetStringRepresentation()
    {
        return "Factory Pattern of each goal.";
    }
}