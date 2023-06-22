public class Goal
{
    private string _goalName;
    private string _description;
    private bool _completed;
    private int _score;
    private string _title;
    private int _points;

    public Goal(string title)
    {
        _title = title;
        _completed = false;
        _score = 0;

    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public virtual int GetScore()
    {
        return _score;
    }

    public virtual string GetGoal()
    {
        Console.WriteLine();
        Console.Write("What is the name of your gosl? ");
        _goalName =  Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description =  Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse( Console.ReadLine());
        string goal = $"{_title},{_goalName},{_description},{_points},{_completed}";
        return goal;
    }


    
}