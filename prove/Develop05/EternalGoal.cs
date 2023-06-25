public class EternalGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    private string _title;
    private string _goal;


    public EternalGoal( string enternalgoal, string title, string description, int points) : base(enternalgoal)
    {
        _goalName = enternalgoal;
        _title = title;
        _description = description;
        _points = points;
    }

    public override string GetGoal()
    {
        _goal = $"{_goalName},{_title},{_description},{_points.ToString()}";
        return _goal;
    }



}