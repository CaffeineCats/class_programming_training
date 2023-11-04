using Microsoft.VisualBasic;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDurationSeconds;

    // Constructor with dummy data.
    public Activity()
    {
       _activityName = "None";
       _activityDescription = "None";
       _activityDurationSeconds = 0;
    }

    // To create constructors in children classes.
    protected void SetActivityName(string name)
    {
        _activityName = name;
    }

    // To create constructors in children classes.
    protected void SetActivityDescription(string description)
    {
        _activityDescription = description;
    }

    // Activity duration setter with user data validation. 
    protected void PromptActivityDuration()
    {
        bool validatingInput = true;

        while (validatingInput)
        {
            try
            {  
                Console.Write("How long, in seconds, would you like for your session? ");
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
        Console.WriteLine($"Welcome to the {_activityName}.\n\nThis activity will {_activityDescription}.\n");
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
        Console.WriteLine("Get Ready...");
        DisplayWheelPauseAnimation(5);
    }

    // Congratulating pause Message for right after each activity.
    protected void DisplayWellDonePause()
    {
        Console.WriteLine("Well Done!!");
        DisplayWheelPauseAnimation(5);
    }

    // Display data about the activity duration to the user, can add other if required in the future.
    protected void DisplayFinalStatistics()
    {
        Console.WriteLine($"You have completed another {_activityDurationSeconds} of the {_activityName}.");
    }

    // Display methods can change to match line position in RunActivity() as the video specified;
}