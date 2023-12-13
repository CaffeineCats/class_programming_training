public class Video
{
    private string _videoTitle;
    private string _videoAuthorName;
    private int _videoSecondsLenght;
    private List<Comment> _comments = new List<Comment>();

    //In case I have a video without comments, It could happen I guess.
    public Video(string title, string authorName, int secondsLenght)
    {
        _videoTitle = title;
        _videoAuthorName = authorName;
        _videoSecondsLenght = secondsLenght;
    }
    public Video(string title, string authorName, int secondsLenght, List<Comment> comments)
    {
        _videoTitle = title;
        _videoAuthorName = authorName;
        _videoSecondsLenght = secondsLenght;
        _comments = comments;
    }

    // If I need to add a single coment to my video comment list (do not know how the interface work).
    public void AppendComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentsNumber()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    // I believe is a better abstraction to let Video display itself, but the methods are public if I need an interface later.
    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Video Title: {_videoTitle} - {_videoSecondsLenght} Seconds\nBy: {_videoAuthorName}");
        Console.WriteLine($"Comments ({GetCommentsNumber()}):\n");
        DisplayComments();
        Console.WriteLine("-------------------------------------------------------------------------------------");
    }
}