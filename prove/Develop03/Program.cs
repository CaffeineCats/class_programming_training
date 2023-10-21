using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Scripture theScripture = new Scripture();

        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());
        theScripture.HideUpToThreeWords();
        Console.WriteLine(theScripture.GetRenderedScriptureText());


        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; " +
                               "in all thy ways acknowledge him, and he shall direct thy paths extraword.";

        Scripture theScriptureWithExtraTestWord = new Scripture(new Reference("Proverbs", 3, 5, 6), scriptureText);


        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());

        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());
        theScriptureWithExtraTestWord.HideUpToThreeWords();        
        Console.WriteLine(theScriptureWithExtraTestWord.GetRenderedScriptureText());                
    }
}