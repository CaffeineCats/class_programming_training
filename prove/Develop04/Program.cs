using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu to Choose Activity.
        Activity activity = new Activity();

        Console.WriteLine("It works");
        Console.Write("It works... ");
        activity.DisplayCountdownAnimationPause(5);
        Console.WriteLine("It sort of works");
    }
}