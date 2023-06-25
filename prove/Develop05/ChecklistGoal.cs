public class ChecklistGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    private string _title;
    private string _times;
    private int _bonus;
    private string _completedTimes;
    private string _goal;


    public ChecklistGoal(string checklistgoal, string title, string description, int points, string times, string bonus) : base(checklistgoal)
    {
       _goalName = checklistgoal;
       _completedTimes = "0";
       _title = title;
       _description = description;
       _points = points;
       _times = times;
       _bonus = int.Parse(bonus);

    }

    public override string GetGoal()
    {

        _goal = $"{_goalName},{_title},{_description},{_points.ToString()},{_completedTimes},{_times},{_bonus}";
        return _goal;
    }



}