public abstract class Activity
{
    // The class is abstract, any instance of Activity would not be specific enough to represent physical exercise activities.
    // Just time would not be enough to calculate distance, speed, or pace.

    private string _date;

    // Since we are computing, I would like to have a variable for doing math instead of calling a GetMinutes() method.
    protected double _minutes;
    private string _activityType; 

    public Activity(string type, string date, double minutesDuration)
    {
        _activityType = type;
        _date = date;
        _minutes = minutesDuration;
    }

    public abstract double GetKmDistance();

    public abstract double GetKphSpeed();

    public abstract double GetMpkmPace();

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_minutes} min) - Distance: {GetKmDistance().ToString("0.0")} km, " +
               $"Speed: {GetKphSpeed().ToString("0.0")} kph, Pace: {GetMpkmPace().ToString("0.00")} min per km";
    }
}