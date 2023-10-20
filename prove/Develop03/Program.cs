using System;

class Program
{
    static void Main(string[] args)
    {
        Word zeWord = new Word("PALABRA");

        Console.WriteLine(zeWord.GetWordAsCurrentVisibility());

        zeWord.HideWord();
        Console.WriteLine(zeWord.GetWordAsCurrentVisibility());
    }
}