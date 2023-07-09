public class Swimming : Activity
{
    private double _laps;
    private double _distance;

    public Swimming( double laps, string date, double duration) : base(date, duration)
    {
        _laps = laps;
        _distance = _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return _distance / base.Getduration() * 60;
    }

    public override double GetPace()
    {
        return base.Getduration( ) / _distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}