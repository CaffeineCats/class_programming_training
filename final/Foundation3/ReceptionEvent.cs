public class ReceptionEvent : Event
{
    private string _confirmationEmail;
    private const string EVENT_TYPE = "Reception";
    
    public ReceptionEvent(string title, string description, string email, string date, string time, EventAddress address) 
           : base(EVENT_TYPE, title, description, date, time, address)
    {
        _confirmationEmail = email;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n-- {_eventType}-- \nPlease send and email to {(_confirmationEmail)} to confirm attendance.";
    }
}