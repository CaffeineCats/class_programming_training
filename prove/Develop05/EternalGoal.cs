public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _basePoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }

    public override string GetStringRepresentation()
    {
        // NEEDS TESTING AND REVIEW
        return $"EternalGoal:{_goalName},{_goalDescription},{_basePoints}";
    }
}