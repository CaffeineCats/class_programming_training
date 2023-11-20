using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        bool keepTracking = true;

        EternalQuestMenu eternalQuest = new EternalQuestMenu();

        while (keepTracking)
        {
            Console.WriteLine($"\nYou have {eternalQuest.GetTotalPoints()} points\n");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals");
            Console.WriteLine("  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    eternalQuest.DisplayUserGoalCreationSubMenu();
                    break;
                
                case 2:
                    eternalQuest.DisplayGoals();
                    break;
                
                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    eternalQuest.DisplayAttemptUserGoalEventSubMenu();
                    break;

                case 6:
                    keepTracking = false;
                    break;
            }
        }
    }
}