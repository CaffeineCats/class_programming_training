using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Scripture TheScripture = new Scripture();

        Console.WriteLine(TheScripture.GetRenderedScriptureText());
    }
}