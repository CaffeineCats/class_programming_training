public class Journal
{
    List<Entry> _Entries = new List<Entry>();

    // I will ignore my modularization Knowledge;
    // I could Get a prompt from a Prompt class method or get a random one from a Prompt list as a member variable here;
    // Get a list with two strings inside from public list<String> GetEntry(string Prompt) and and pass them to the newEntry instance inside public void WriteEntry();
    // Get a string from string GetDateFromSystem() and pass it to the newEntry instance;
    // Pass those three strings to AppendToList(date, prompt, userAnswer)
    // Or I could just do all that inside WriteEntry(), I will go the lazy way, please correct me if it should have been the other way.

    public void WriteUserInputEntryToList()
    {   
        // New Entry instance.
        Entry appendableEntryObject = new Entry();

        // Get Prompt Here, pass it to Entry instance member variable.
        string randomPrompt = "Have you seen Joe";
        appendableEntryObject._entryPrompt = randomPrompt;

        //Get user answer and pass it to Entry instance member variable.
        Console.Write($"{randomPrompt}");
        appendableEntryObject._entryAnswer = Console.ReadLine();


        // Get the system date as String from DateTime, pass it Entry instance member variable.
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        appendableEntryObject._entryDate = dateText;

        // Append to _Entries member variable.
        _Entries.Add(appendableEntryObject);

    }


}