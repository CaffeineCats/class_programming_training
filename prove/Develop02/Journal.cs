// For C# to know where to get the StreamWriter class from.
using System.IO; 

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    //PromptManager _promptHandler = new PromptManager();

    // As you can see no method has any parameters, that is why the Prompt class has a member variable in Journal Class;
    // I am not sure if this is a good practice or how it should be really done;
    // I did it that way because I want one list of Prompts to work all across my program;
    // Otherwise I believe I would have had one different list when creating a prompt and when using the option of appending new prompt;
    // Because I would have created two instances within each method, I needed to be the same instance, so is a member variable.
    // Also I do not know if It's a good practice to not use parameters it feels like calling global variables, is weird, a large system design would be madness.

    public void WriteUserInputEntryToList()
    {   
        /*We get Prompt the user with a random question, append all the related data to _Entries*/

        /* I will ignore my modularization knowledge;
        I could Get a prompt from a Prompt class method or get a random one from a Prompt list as a member variable here;
        Get a list with two strings inside from public list<String> GetEntry(string Prompt) and and pass them to the newEntry instance inside public void WriteEntry();
        Get a string from string GetDateFromSystem() and pass it to the newEntry instance;
        Pass those three strings to AppendToList(date, prompt, userAnswer)
        Or I could just do all that inside WriteEntry() and save me time and effort;
        I will go the lazy way, please correct me if it should have been the other way.*/


        // New Entry instance with the purpose of being appended.
        Entry appendableEntryObject = new Entry();

        // Get Prompt Here, pass it to Entry instance member variable.
        string randomPrompt = "Have you seen Joe";
        appendableEntryObject._entryPrompt = randomPrompt;

        //Get user answer and pass it to Entry instance member variable.
        Console.Write($"{randomPrompt}");
        appendableEntryObject._entryAnswer = Console.ReadLine();


        // Get the system date as String from DateTime, pass it Entry instance member variable.
        // Taken from activity description.
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        appendableEntryObject._entryDate = dateText;

        // Append to _Entries member variable.
        _entries.Add(appendableEntryObject);

    }

    public void DisplayEntries()
    {
        // Displayin' with the boys.
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void WriteFile()
    {
        //We write _entries into a text file.
        /*The text file is provided by system;
        If I wanted the user to interact with the file (and is a good Idea) I would have created an extra class.*/

        using (StreamWriter outPutFile = new StreamWriter("Entries.txt"))
        {
            foreach (Entry entry in _entries)
            {
                outPutFile.WriteLine($"{entry._entryDate}~|~{entry._entryPrompt}~|~{entry._entryAnswer}");
            }
        }
    }

    public void ReadFile()
    {
        //Read list of entries from a text file
        string[] lines = System.IO.File.ReadAllLines("Entries.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];

            Entry appendableEntryObject = new Entry();

            appendableEntryObject._entryDate = date;
            appendableEntryObject._entryPrompt = prompt;
            appendableEntryObject._entryAnswer = answer;

            _entries.Add(appendableEntryObject);
        }
        
    }


}