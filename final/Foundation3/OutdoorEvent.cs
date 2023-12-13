public class OutdoorGatheringEvent : Event
{
    private string _weatherStatement;
    private const string EVENT_TYPE = "Outdoor Gathering";
    
    public OutdoorGatheringEvent(string title, string description, string weather, string date, string time, EventAddress address) 
           : base(EVENT_TYPE, title, description, date, time, address)
    {
        _weatherStatement = weather;
    }

     public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n-- {_eventType} --\n The weather prediction for that day is {_weatherStatement}," +
        "please dress accordingly";
    }
}