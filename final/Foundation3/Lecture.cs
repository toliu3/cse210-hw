public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Full Details:\n-------------\nType of the Event: Lecture\n{base.GetStanderDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
    }
}