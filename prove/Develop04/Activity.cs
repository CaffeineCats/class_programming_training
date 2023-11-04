using Microsoft.VisualBasic;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDurationSeconds;

    // Placeholder constructor with data that should not see the day of light, ever.
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
    //Activity duration setter with user data validation. 
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

    public void DisplayCountdownAnimationPause(int pauseSecondsDuration)
    {
        for (int i = pauseSecondsDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    // ACtivity Child Class Execution

    // Good Job Ending Message Display Method - Message : Good Job, Activity Completed Name and Pause For Several Seconds Animation
}