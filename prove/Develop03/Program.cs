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
    }
}