using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName()
        {
            Console.Write("Please Enter Your Name: ");
            string wholeName = Console.ReadLine();
            return wholeName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please Enter Your Favorite Number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            double squaredNumberDouble = Math.Pow(number, 2);
            int squaredNumber = Convert.ToInt32(squaredNumberDouble);
            return  squaredNumber;
        }

        static void DisplayResult(string userName, int numberSquared)
        {
            Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
        }

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int numberSquared = SquareNumber(userNumber);
            DisplayResult(userName, numberSquared);
        }

        Main();

    }
}