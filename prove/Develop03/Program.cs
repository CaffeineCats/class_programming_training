using System;
using System.Net.Quic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {   
        // Default Constructor - Pre Loaded Data
        Scripture theScripture = new Scripture();

        Console.Clear();

        Console.WriteLine($"{theScripture.GetRenderedScriptureText()}\n");

        // I am going to assume the user knows how to follow instructions to avoid validating an enter input.
        // Works more like press any button to continue or press quit to leave.
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string userInput = Console.ReadLine();

        // Keeps going as long as the user wants, or until the user runs out of visible words.
        // When no visible words left, it forces a quit, so it actually ends when the user has no words left;
        // With a kind message, so the user does not get traumatized.
        // Some more extra messages for increased encouragement towards the user.
        
        while(userInput != "quit")
        {
            Console.Clear();
            
            theScripture.HideUpToThreeWords();

            Console.WriteLine($"{theScripture.GetRenderedScriptureText()}\n");

            if (theScripture.AreThereUnHiddenWordsLeft())
            {
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();

                if(userInput == "quit")
                {
                    Console.WriteLine("Sad to see you go, please try again sometime, You Can Do It!\nYou Are Amazing!!!");
                }
            }
            else
            {
                Console.WriteLine("Congratulations, you are a little wiser than yesterday!");
                userInput = "quit";
            }

        }
    }
}