public abstract class Activity
{
    private string _date;
    private double _duration;


    public Activity( string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public double Getduration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetType().Name} ({_duration} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
              
    }

}