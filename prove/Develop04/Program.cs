using System;
using System.Collections;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        
        while(runProgram)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing Activiy\n  4. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        BreathingActivity activityOne = new BreathingActivity();
                        activityOne.RunBreathingActivity();
                        break;

                    case 2:
                        ReflectionActivity activityTwo = new ReflectionActivity();
                        activityTwo.RunReflectingActivity();
                        break;

                    case 3:
                        ListingActivity activityThree = new ListingActivity();
                        activityThree.RunListingActivity();
                        break;

                    case 4:
                        runProgram = false;
                        break;
                }
            }
            catch
            {   
                Console.WriteLine("\nPlease provide an integer that reflects a menu option.");
                Thread.Sleep(4500);
            }    
        }
    }
}