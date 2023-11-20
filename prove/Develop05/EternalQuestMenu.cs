public class EternalQuestMenu
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    private void AppendSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        _goals.Add(new SimpleGoal(name, description, points));
    }

    private void AppendEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        _goals.Add(new EternalGoal(name, description, points));
    }

    private void AppendChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int goalLimit = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        _goals.Add(new ChecklistGoal(name, description, points, bonusPoints, goalLimit));
    }

    public void DisplayUserGoalCreationSubMenu()
    {
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalOption = int.Parse(Console.ReadLine());

        switch(goalOption)
        {
        case 1:
            AppendSimpleGoal();
            break;
        case 2:
            AppendEternalGoal();
            break;
        case 3:
            AppendChecklistGoal();
            break;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");

        int goalNumber = 0;

        foreach (Goal goal in _goals)
        {
            goalNumber++;

            Console.Write($"{goalNumber}. ");
            goal.DisplayGoal();
        }
    }

    public void DisplayAttemptUserGoalEventSubMenu()
    {
        Console.WriteLine("The goals are:");

        int goalNumber = 0;

        foreach (Goal goal in _goals)
        {
            goalNumber++;
            Console.WriteLine($"{goalNumber}. {goal.GetGoalName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int option = int.Parse(Console.ReadLine());

        // To option - 1 is to match the list indexes with the user input.
        // If goal is NOT complete, trigger event, otherwise inform user of completion.
        if (!_goals[option - 1].IsComplete())
        {
            int points = _goals[option - 1].RecordEvent();

            _totalPoints += points;

            Console.WriteLine($"Congratulations! You have earned {points} points!\nYou now have {_totalPoints} points.");
        }
        else
        {
            Console.WriteLine($"The goal {_goals[option - 1].GetGoalName()} is already completed!");
        }
    }

}