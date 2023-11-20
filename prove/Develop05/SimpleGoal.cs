using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;

        return _basePoints;
    }

    public override void DisplayGoal()
    {
        string completionMark = IsComplete() ? "X" : " ";

        Console.WriteLine($"[{completionMark}] {base.GetGoalName()} ({_goalDescription})");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetGoalName()},{_goalDescription},{_basePoints},{_isComplete}";
    }
}