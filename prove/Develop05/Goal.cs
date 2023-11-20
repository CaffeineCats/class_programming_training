public abstract class Goal
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

    public abstract bool IsComplete();

    public abstract int RecordEvent();

    public abstract void DisplayGoal();

    public abstract string GetStringRepresentation();
}