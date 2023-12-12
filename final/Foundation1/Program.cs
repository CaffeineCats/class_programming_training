using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video videoOne = new Video("OH NO FINALS WEEK", "Luis Riquelme", 120);
        videoOne.AppendComment(new Comment("Luis Riquelme", "He, My video."));
        videoOne.AppendComment(new Comment("Random Banana", "GRAB THE POTASSIUM."));
        videoOne.AppendComment(new Comment("STRESSED OMG", "Is it finals week, or your final week?"));

        videos.Add(videoOne);

        Video videoTwo = new Video("I'm dead, gone wrong, STORY TIME", "Mediocre Youtuber", 3600);
        videoTwo.AppendComment(new Comment("ANNON-YING", "BOO YOU SUCK."));
        videoTwo.AppendComment(new Comment("DAREALSAUCE", "Your are not a clown, YOU ARE THE WHOLE YOUTUBE COMMENT SECTION."));
        videoTwo.AppendComment(new Comment("CRINGEMARIO", "This is definetely one of the videos of all time."));

        videos.Add(videoTwo);

        Video videoThree = new Video("PACO-POLICIA", "DUCKTATOR", 1200);
        videoThree.AppendComment(new Comment("Luis Riquelme1", "I need to sleep."));
        videoThree.AppendComment(new Comment("Luis Riquelme2", "I'm running out of ideas."));
        videoThree.AppendComment(new Comment("Luis Riquelme3", "CAN YOU BELIEVE IT GUYS, CHIRSTMAS, WEEK AND A HALF AWAY, WOW."));

        videos.Add(videoThree);

        Console.Clear();

        foreach (Video video in videos)
        {
            video.DisplayVideoInformation();
        }

    }       
}