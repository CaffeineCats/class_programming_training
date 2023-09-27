using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int userGuess = 0;

        do
        {
            Console.Write("What is your Guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower mah boy");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher mah boy");
            }
            else
            {
                Console.WriteLine("You got it right, U r a wizzard Harry, A WIZZARD.");
            }
        } while (userGuess != magicNumber);
    }
}