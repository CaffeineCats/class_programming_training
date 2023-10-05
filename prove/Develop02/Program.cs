using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entryTest = new Entry();

        entryTest._entryDate = "Today LOL";
        entryTest._entryPrompt = "Have you seen Joe?";
        entryTest._entryAnswer = "JOE MAMA";

        entryTest.DisplayEntry();
    }
}