public class RunningActivity : Activity
{
    private double _kmDistance;
    private const string ACVTIVIY_TYPE = "Running";

    public RunningActivity(string date, double minutesDuration, double distanceKm) : base (ACVTIVIY_TYPE, date, minutesDuration)
    {
        _kmDistance = distanceKm;
    }

    public override double GetKmDistance()
    {
        return _kmDistance;
    }

    public override double GetKphSpeed()
    {
        return (_kmDistance / _minutes) * 60;
    }

    public override double GetMpkmPace()
    {
        return _minutes / _kmDistance;
    }
}