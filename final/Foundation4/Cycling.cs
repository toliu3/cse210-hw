public class Cycling : Activity
{
    private double _speed;

    public Cycling( double speed, string date, double duration) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetDistance()
    {
        return _speed * (base.Getduration() / 60);
    }
}