public class Event
{
    protected string _eventType;
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private EventAddress _address;

    // I protected it for I do not want to create non specific instances of an event.
    protected Event(string type, string title, string description, string date, string time, EventAddress address)
    {
        _eventType = type;
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"-- {_eventTitle} -- \n{_eventDescription}\n{_eventDate} at {_eventTime}.\n{_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"--{_eventTitle}-- \n{_eventType} - {_eventDate}";
    }

}