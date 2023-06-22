public class EternalGoal : Goal
{
    private string _goalName;
    private string _description;
    private string _points;
    private string _title;
    public EternalGoal( string enternalgoal) : base(enternalgoal)
    {
        _title = enternalgoal;
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
        string goal = $"{_title},{_goalName},{_description},{_points}";
        return goal;
    }

}