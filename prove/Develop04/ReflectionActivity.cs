using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{   
    private List<string> _mainReflectivePromptList;
    private List<string> _reflectivePrompts;
    public ReflectionActivity()
    {
        base.SetActivityName("Reflection Activity");
        base.SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.");

        _mainReflectivePromptList = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you fought for the right cause.",
            "Think of a time when you did something for a loved one."
        };

        _reflectivePrompts = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    private void DisplayRandomMainPrompt()
    {   
        Random random = new Random();
        int randomIndex = random.Next(0, _mainReflectivePromptList.Count);

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n -- {_mainReflectivePromptList[randomIndex]} --");
    }

    private void DisplayReflectiveRandomPromptPause()
    {   
        Random random = new Random();
        int randomIndex = random.Next(0, _reflectivePrompts.Count);

        Console.Write($"> {_reflectivePrompts[randomIndex]} ");
        base.DisplayWheelPauseAnimation(15);
        Console.WriteLine();
    }

    public void RunReflectingActivity()
    {
        base.DisplaySartingMessage();
        base.PromptActivityDuration();
        base.DisplayGetReadyPause();

        DisplayRandomMainPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        base.DisplayCountdownAnimationPause(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDurationSeconds);

        int activityCounter = 0;

        while (DateTime.Now < endTime)
        {
            DisplayReflectiveRandomPromptPause();
            activityCounter++;
        }

        base.DisplayWellDonePause();

        // The total duration in seconds is 15 per reflection prompt.
        int totalSeconds = activityCounter * 15;

        base.DisplayFinalStatistics(totalSeconds);

    }

}
