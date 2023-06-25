public class SimpleGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    private string _title;
    private bool _completed;
    private string _goal;



    public SimpleGoal(string simplegoal, string title, string description, int points) : base(simplegoal)
    {
        _goalName = simplegoal;
        _title = title;
        _description = description;
        _points = points;
        _completed = false;
    }
    public override string GetGoal()
    {
        _goal = $"{_goalName},{_title},{_description},{_points.ToString()},{_completed}";
        return _goal;
    }

    


}