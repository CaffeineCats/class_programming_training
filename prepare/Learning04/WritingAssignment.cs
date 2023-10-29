public class WritingAssignment : Assignnment 
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{base.GetSummary()}\n{_title} by {_studentName}";
    }
}   
