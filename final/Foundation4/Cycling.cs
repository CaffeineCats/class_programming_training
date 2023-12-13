public class CyclingActivity : Activity
{
    private double _kphSpeed;
    private const string ACVTIVIY_TYPE = "Cycling";

    public CyclingActivity(string date, double minutesDuration, double speed) : base (ACVTIVIY_TYPE, date, minutesDuration)
    {
        _kphSpeed = speed;
    }

    public override double GetKmDistance()
    {
        return _kphSpeed * (_minutes / 60);
    }

    public override double GetKphSpeed()
    {
        return _kphSpeed;
    }

    public override double GetMpkmPace()
    {
        return 60 / _kphSpeed;
    }
}   