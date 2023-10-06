public class PromptManager
{
    public List<string> _prompts;

    //The purpose of the Prompt manager is to manage all the prompts that are feed to journal;
    // That is why it has its own class, and is a member variable in Journal;
    // If the user adds a prompt to the list or pops one (we would need a file for that), but the default ones are at the constructor;
    // I want that prompt list to be the same all across the program.
    public PromptManager()
    {
        _prompts = new List<string> 
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? "
        };
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();

        // The second parameter of Next is non inclusive so it gets the indexes right.
        int randomNumber = randomGenerator.Next(0, _prompts.Count);

        return _prompts[randomNumber];
    }
    // Stretch challenge, sorry it's so simple.
    public void AddUserPrompt()
    {
        Console.Write("Please write your prompt: ");
        string newPrompt = Console.ReadLine();
        _prompts.Add(newPrompt);
    }
    // We would need a file and functions to work without the user knowledge for a file to hold the prompts.
}