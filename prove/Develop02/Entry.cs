public class Entry
{
    public string _entryPrompt = "";
    public string _entryAnswer = "";
    public string _entryDate = "";

    // So far this class holds and display a single entry.
    // It might change due to prompt generation.
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_entryPrompt}\n{_entryAnswer}");
    }
}