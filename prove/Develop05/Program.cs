using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuest eternalQuest = new EternalQuest();

        eternalQuest.AppendEternalGoal();
        eternalQuest.AppendChecklistGoal();
        eternalQuest.AppendSimpleGoal();

        eternalQuest.DisplayGoals();
    }
}