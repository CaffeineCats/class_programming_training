public abstract class Goal
{
    // Abstract classes can be declared but not instanciated.
    private string _goalName;
    protected string _goalDescription;
    protected int _basePoints;
    
    // This class cannot be instanciated, so if public or private is the same.
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _basePoints = points;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public abstract bool IsComplete();

    public abstract int RecordEvent();

    public abstract void DisplayGoal();

    public abstract string GetStringRepresentation();
}