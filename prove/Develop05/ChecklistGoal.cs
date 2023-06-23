public class ChecklistGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    private string _title;
    private string _times;
    private string _bonus;
    private string _completedTimes;
    private string _goal;


    public ChecklistGoal(string checklistgoal) : base(checklistgoal)
    {
       _title = checklistgoal;
       _completedTimes = "0";
    }

    public override string GetGoal()
    {
        Console.WriteLine();
        Console.Write("What is the name of your gosl? ");
        _goalName =  Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description =  Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse( Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _times =  Console.ReadLine();
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = Console.ReadLine();

        _goal = $"{_title},{_goalName},{_description},{_points},{_completedTimes},{_times},{_bonus}";
        return _goal;
    }

}