public class LectureEvent : Event
{
    private string _speakerName; 
    private int _attendantsMaxCapacity;
    private const string EVENT_TYPE = "Lecture";

    public LectureEvent(string title, string description, string speakerName, int capacity
           , string date, string time, EventAddress address) 
           : base(EVENT_TYPE, title, description, date, time, address)
    {
        _speakerName = speakerName;
        _attendantsMaxCapacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n-- {_eventType} --\nThe speaker of the lecture will be {_speakerName}.\n" +
        $"The event has a max capacity of {_attendantsMaxCapacity} attendants.";
    }

}