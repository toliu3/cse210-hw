public class Running : Activity
{
    private double _distance;

    public Running( double distance, string date, double duration) : base(date, duration)
    {
        _distance = distance;
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