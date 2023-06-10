public class BreathingAct : Activity
{
private string _breatheInActivity;
private string _breatheOutActivity;

public BreathingAct (string name, string description, string breatheInActivity, string breatheOutActivity) : base(name,description)
{
    _breatheInActivity = breatheInActivity;
    _breatheOutActivity = breatheOutActivity;
}

public void BreatheStart()
{

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
        Console.Write(_breatheInActivity);
        CountDown(4);
        Console.WriteLine();
        Console.Write(_breatheOutActivity);
        CountDown(6);
        Console.WriteLine();
        Console.WriteLine();

    }
    
}

}