using System.Reflection.Metadata;

public class ListingActivity : Activity
{   
    private const string ACTIVITY_DESCRIPTION = "This activity will help you reflect on the good things in your life " + 
    "by having you list as many things as you can in a certain area.";
    private List<string> _reflectionPrompts;
    private List<string> _answerList = new List<string>();

    public ListingActivity() : base("Listing Activity", ACTIVITY_DESCRIPTION)
    {
        _reflectionPrompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
    }

    private void DisplayInitialRandomPromptMessagePause()
    {   
        Random random = new Random();
        int randomIndex = random.Next(0, _reflectionPrompts.Count);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" -- {_reflectionPrompts[randomIndex]} --");
    }

    private void AppendPromptAnswer()
    {
        Console.Write("> ");
        _answerList.Add(Console.ReadLine());
    }

    public void RunReflectingActivity()
    {
        base.DisplaySartingMessage();
        base.PromptActivityDuration();
        base.DisplayGetReadyPause();

        DisplayInitialRandomPromptMessagePause();
        Console.Write("You may begin in: ");
        base.DisplayCountdownAnimationPause(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDurationSeconds);

        while (DateTime.Now < endTime)
        {
            AppendPromptAnswer();
        }

        Console.WriteLine($"You listed {_answerList.Count} items!");

        base.DisplayWellDonePause();

        // The duration of this activity is an estimate, the one provided by user.
        // The activity can go longer than the user specified in seconds if no answer is provided.
        // We will assume that the user did total use of the time as best as posible.
        base.DisplayFinalStatistics(_activityDurationSeconds);

    }
}