using System.Collections;

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
            Console.WriteLine($"The goal '{_goals[option - 1].GetGoalName()}' is already completed, CONGRATULATIONS," +
            " THANK YOU SO MUCH A-FOR-TO PLAYING MY GAME! SOLONGEBOWSER! (Super Mario 64 Reference)");
        }
    }

    public void WriteGoalsToUserTextFile()
    {
        // StreamWritter Overrides existing files, meaning it will be content erased before writing new content.

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void AppendGoalsFromUserTextFile()
    {   

        _goals.Clear();

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] factoryPattern = lines[i].Split(":");
            string[] goalAtributes = factoryPattern[1].Split(",");

            switch(factoryPattern[0])
            {
                case "SimpleGoal":
                    // goal name, goal description, goal base points and completion bool with the proper format and conversion.
                    _goals.Add(new SimpleGoal(goalAtributes[0], goalAtributes[1], int.Parse(goalAtributes[2]), Convert.ToBoolean(goalAtributes[3].ToLower())));
                    break;
                case "EternalGoal":
                    // goal name, goal description, goal base points.
                    _goals.Add(new EternalGoal(goalAtributes[0], goalAtributes[1], int.Parse(goalAtributes[2])));
                    break;
                case "ChecklistGoal":
                    // goal name, goal description, goal base points, bonus points, goal limit and goal counter.
                    _goals.Add(new ChecklistGoal(goalAtributes[0], goalAtributes[1], int.Parse(goalAtributes[2]), int.Parse(goalAtributes[3]), int.Parse(goalAtributes[4]), int.Parse(goalAtributes[5])));
                    break;
            }
        } 
    }

}