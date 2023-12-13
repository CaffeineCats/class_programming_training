public class SwimmingActivity : Activity
{
    private int _swimmingLaps;
    private const string ACVTIVIY_TYPE = "Swimming";

    public SwimmingActivity(string date, double minutesDuration, int lap) : base (ACVTIVIY_TYPE, date, minutesDuration)
    {
        _swimmingLaps = lap;
    }

    public override double GetKmDistance()
    {
        return _swimmingLaps * 50 / 1000;
    }

    public override double GetKphSpeed()
    {
        return (GetKmDistance() / _minutes) * 60;
    }

    public override double GetMpkmPace()
    {
        return _minutes / GetKmDistance();
    }
}