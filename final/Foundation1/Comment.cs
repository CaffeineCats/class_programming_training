public class Comment
{
    private string _commentAuthorName;
    private string _commentText;

    public Comment(string authorName, string comment)
    {
        _commentAuthorName = authorName;
        _commentText = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"@{_commentAuthorName} some time ago\n{_commentText}\n");
    }

}