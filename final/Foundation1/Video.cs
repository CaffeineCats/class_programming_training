public class Video
{
    private string _videoTitle;
    private string _videoAuthorName;
    private int _videoSecondsLenght;
    private List<Comment> _comments = new List<Comment>();

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

    public void AppendComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int GetCommentsNumber()
    {
        return _comments.Count;
    }

    private void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Video Title: {_videoTitle} - {_videoSecondsLenght} Seconds\nBy: {_videoAuthorName}");
        Console.WriteLine($"Comments ({GetCommentsNumber()}):\n");
        DisplayComments();
        Console.WriteLine("-------------------------------------------------------------------------------------");
    }
}