public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _goalLimit;
    private int _goalCounter;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int goalLimit) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _goalLimit = goalLimit;
        _goalCounter = 0;
    }

    public override bool IsComplete()
    {
        bool completion = _goalCounter < _goalLimit ? false : true;
        return completion;
    }

    public override int RecordEvent()
    {
        _goalCounter++;

        int points = IsComplete() ? _basePoints + _bonusPoints : _basePoints;
        return points;
    }

    public override void DisplayGoal()
    {
        string completionMark = IsComplete() ? "X" : " ";

        Console.WriteLine($"[{completionMark}] {base.GetGoalName()} ({_goalDescription}) -- Currently completed: {_goalCounter}/{_goalLimit}");
    }

    public override string GetStringRepresentation()
    {
        // NEEDS TESTING AND REVIEW
        return $"ChecklistGoal:{base.GetGoalName()},{_goalDescription},{_basePoints},{_bonusPoints},{_goalLimit},{_goalCounter}";
    }
}