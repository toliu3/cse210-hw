public class SimpleGoal : Goal
{
    private string _goalName;
    private string _description;
    private string _points;
    private string _title;
    private bool _completed;
    private string _goal;


    public SimpleGoal(string simplegoal) : base(simplegoal)
    {
        _title = simplegoal;
        _completed = false;
    }
    public override string GetGoal()
    {
        Console.WriteLine();
        Console.Write("What is the name of your gosl? ");
        _goalName =  Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description =  Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine();
        _goal = $"{_title},{_goalName},{_description},{_points},{_completed}";
        return _goal;
    }
    


}