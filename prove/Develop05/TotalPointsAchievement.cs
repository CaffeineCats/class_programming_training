using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class TotalPointsAchievement
{
    string _achievementName;
    int _totalPointsGoal; 
    bool _isComplete;

    public TotalPointsAchievement(string name, int totalPointsGoal)
    {
        _totalPointsGoal = totalPointsGoal;
        _isComplete = false;
    }

    public void DisplayIfPossible(int totalPoints)
    {
        if (!_isComplete && totalPoints >= _totalPointsGoal)
        {
            Console.WriteLine($"CONGRATULATIONS!!!\nYou have achieved {_achievementName}: \nBy Achieving the {_totalPointsGoal} Total Points Mark!\n'");
            _isComplete = true;
        }
    }
} 