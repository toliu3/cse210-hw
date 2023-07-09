public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering ( string weather,  string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"Full Details:\n-------------\nType of the Event: OutdorGathering\n{base.GetStanderDetails()}\nWeather: {_weather}\n";
    }


}