public class Entry
{
    public string _entryPrompt = "";
    public string _entryAnswer = "";
    public string _entryDate = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_entryPrompt}\n{_entryAnswer}");
    }
}