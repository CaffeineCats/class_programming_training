using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("03 NOV 2022", 30, 4.8));
        activities.Add(new CyclingActivity("10 DIC 2023", 20, 28));
        activities.Add(new SwimmingActivity("1 JAN 2000", 20, 30));

        Console.Clear();

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}\n");
        }

    }
}