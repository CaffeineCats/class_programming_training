using System.Diagnostics;

public class BreathingActivity : Activity
{
    private const string ACTIVITY_DESCRIPTION = "This activity will help you relax by walking your through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.\n" +
        "Breath in, hold in, Breath out and hold out, in periods of four seconds each, then repeat.";

    public BreathingActivity() : base("Breathing Activity", ACTIVITY_DESCRIPTION) 
    {
        // Nutin' here yet.
    }

    private void DisplayBreathingCicle()
    {
        Console.Write("\n\nBreath in...");
        base.DisplayCountdownAnimationPause(4);
        Console.Write("\nHold in...");
        base.DisplayCountdownAnimationPause(4);
        Console.Write("\nNow Breath out...");
        base.DisplayCountdownAnimationPause(4);
        Console.Write("\nHold out...");
        base.DisplayCountdownAnimationPause(4);
    }

    public void RunBreathingActivity()
    {
        base.DisplaySartingMessage();
        base.PromptActivityDuration();
        base.DisplayGetReadyPause();

        // A time loop to make the activity last the user specified seconds.
        // _activityDurationSeconds is set by the user in PromptActivityDuration(), and is a protected parent member variable.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDurationSeconds);

        int activityCounter = 0;

        while (DateTime.Now < endTime)
        {
            DisplayBreathingCicle();
            activityCounter++;
        }

        // There is two new lines specified in the video here, the other one is a \n iniside the next method.
        Console.WriteLine();
        base.DisplayWellDonePause();

        // The total duration in seconds is 16 per breathing cicle.
        int totalSeconds = activityCounter * 16;

        base.DisplayFinalStatistics(totalSeconds);

    }

}   