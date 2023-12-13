using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        LectureEvent eventOne = new LectureEvent("Video Game Design", "Introduction to Video Game Industry", "Julius Jogo", 50
        , "12/20/2023", "7:00 pm", new EventAddress("7767 Lantern Ave.", "Fresno", "California", "United States"));
        
        Console.WriteLine(eventOne.GetStandardDetails());
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine(eventOne.GetFullDetails());
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine(eventOne.GetShortDescription());
        Console.WriteLine("\n--------------------------------\n");

        ReceptionEvent eventTwo = new ReceptionEvent("Monica & Luke Marriage After-Party", "Let's Celebrate together the newly weds"
        , "eventplanner@gmail.com", "10/10/10", "6:30 pm", new EventAddress("7543 Aspen St.", "Butte", "Montana", "United States"));
        
        Console.WriteLine(eventTwo.GetStandardDetails());
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine(eventTwo.GetFullDetails());
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine(eventTwo.GetShortDescription());
        Console.WriteLine("\n--------------------------------\n");

        OutdoorGatheringEvent eventThree = new OutdoorGatheringEvent("Beach Party", "Summer Start Celebration", "Sunny"
        , "12/21/2021", "10 am", new EventAddress("Playa Trocadero", "Antofagasta", "Antofagasta", "Chile"));
        
        Console.WriteLine(eventThree.GetStandardDetails());
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine(eventThree.GetFullDetails());
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine(eventThree.GetShortDescription());
        Console.WriteLine("\n--------------------------------\n");
    }
}