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

        videos[0].DisplayVideoInformation();

    }
}