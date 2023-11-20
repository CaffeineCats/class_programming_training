using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{
    private bool _completion;

    public SimpleGoal(string name, string description, int points, bool completion = false) : base(name, description, points)
    {
        _completion = completion;
    }

    public override bool IsComplete()
    {
        return _completion;
    }

    public override int RecordEvent()
    {
        _completion = true;

        return _basePoints;
    }

    public override void DisplayGoal()
    {
        string completionMark = IsComplete() ? "X" : " ";

        Console.WriteLine($"[{completionMark}] {base.GetGoalName()} ({_goalDescription})");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetGoalName()},{_goalDescription},{_basePoints},{_completion}";
    }
}