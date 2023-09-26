using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        // It seems like this is a comment.
        // Variable names are Camel Case as a good practice I believe.

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Seems like a Console.WriteLine() will print an empty line, seems like there is no way to \n for input;
        Console.WriteLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
    }
}