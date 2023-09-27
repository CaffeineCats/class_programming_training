using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your final grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        Console.WriteLine();

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter= "D";
        }
        else
        {
            letter = "F";
        } 

        Console.WriteLine($"You Got MAIL: {letter}");

        // I wonder if the teacher read these

        if (gradePercentage >= 70)
        {
            Console.WriteLine("YOU DID IT, YOU ARE THE BEST AROUND, NOTHING IS GONNA EVER KEEP YOU DOWN");
        }
        else
        {
            Console.WriteLine("Sonic says: Better luck next time!!!");
        }




        
        
    
    }
}