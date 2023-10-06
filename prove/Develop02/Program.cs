using System;
// Do not know what this one is, it showed up out of nowhere.
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        bool displayMenu = true;

        while (displayMenu)
        {

            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n6.Add New Prompt");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
        
            Journal journal = new Journal();

            if (choice == 1)
            {
                journal.WriteUserInputEntryToList();
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename: ");
                string fileName = Console.ReadLine();
                journal.ReadFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename: ");
                string fileName = Console.ReadLine();                
                journal.WriteFile(fileName);
            }
            else if (choice == 5)
            {
                displayMenu = false;
            }
            else if (choice == 6)
            {
                journal._promptHandler.AddUserPrompt();
            }
        }    
    }    
}