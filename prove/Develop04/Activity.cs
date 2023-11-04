using Microsoft.VisualBasic;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    protected int _activityDurationSeconds;

    protected Activity(string activityName, string activityDescription) 
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    // Activity duration setter with user data validation. 
    protected void PromptActivityDuration()
    {
        bool validatingInput = true;

        while (validatingInput)
        {
            try
            {  
                // I add the approximatedly because I will compute the exact seconds spent in an activity.
                // For instance, a breathing cicle lasts 16 seconds, if user inputs 30 sseconds, the activity will run for 32 seconds;
                // I will compute the exact time and display those 32 seconds in the final message.
                Console.Write("How long approximatedly, in seconds, would you like for your session? ");
                int inputSeconds = int.Parse(Console.ReadLine());

                if (inputSeconds > 0)
                {
                    _activityDurationSeconds = inputSeconds;
                    validatingInput = false;
                }

                else
                {
                    Console.WriteLine("The activity must last more than 0 seconds, please provide a new duration.\n");
                }

            }

            catch
            {
                Console.WriteLine("Not an appropiate duration in seconds, please provide a new one.\n");
            }
        }
    }

    // Initial message displayer.
    protected void DisplaySartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_activityDescription}\n");
    }

    // A countdown, format strings around it to display as required.
    protected void DisplayCountdownAnimationPause(int pauseSecondsDuration)
    {
        int countdown = pauseSecondsDuration;

        // It's odd how this time loop must be specifically written this way for it to work;
        // Probably has something to do with DateTime data type.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(pauseSecondsDuration);

        while (DateTime.Now < endTime) 
        {
            Console.Write(countdown);
            Thread.Sleep(1000);
            // Modify here for more than one digit.
            Console.Write("\b \b");

            countdown--;
        }
    }

    // A wheel animation pause, format strings around it ti display as required.
    protected void DisplayWheelPauseAnimation(int pauseSecondsDuration)
    {
        List<string> animationFramesStringList = new List<string>() {"|", "/", "-", "\\"};

        int animationItemIndex = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(pauseSecondsDuration);

        while (DateTime.Now < endTime) 
        {
            string stringFrame = animationFramesStringList[animationItemIndex];
            Console.Write(stringFrame);
            Thread.Sleep(250);
            Console.Write("\b \b");

            animationItemIndex++;

            if (animationItemIndex >= animationFramesStringList.Count)
            {
                animationItemIndex = 0;
            } 
        }

    }

    // Get Ready Pause Message for right before each activity.
    protected void DisplayGetReadyPause()
    {   
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplayWheelPauseAnimation(5);
    }

    // Congratulating pause Message for right after each activity.
    protected void DisplayWellDonePause()
    {
        Console.WriteLine("\n\nWell Done!!");
        DisplayWheelPauseAnimation(5);
    }

    // Display data about the activity duration to the user, can add other statistics if required in the future.
    // I want to compute the exact seconds that the user spents in the activity;
    // Because each activity is different I pass the computation result as an argument, for the computation might be different per activity.
    protected void DisplayFinalStatistics(int activityTotalDurationSeconds)
    {
        Console.WriteLine($"\nYou have completed another {activityTotalDurationSeconds} seconds of the {_activityName}.");
        DisplayWheelPauseAnimation(7);
    }
}