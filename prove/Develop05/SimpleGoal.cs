using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{
    private bool _keepInteracting;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _keepInteracting = true;
    }

    public override bool IsComplete()
    {
        bool completion = _keepInteracting ? true : false;
        return completion;
    }

    public override int RecordEvent()
    {
        _keepInteracting = false;

        return _basePoints;
    }

    public override void DisplayGoal()
    {
        string completionMark = IsComplete() ? "X" : "";

        Console.WriteLine($"[{completionMark}] {_goalName} ({_goalDescription})");
    }

    public override string GetStringRepresentation()
    {
        // NEEDS TESTING AND REVIEW
        return $"SimpleGoal:{_goalName},{_goalDescription},{_basePoints},{_keepInteracting}";
    }
}