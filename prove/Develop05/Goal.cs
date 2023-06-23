public class Goal
{
    private string _score;
    private string _title;

    public Goal(string title)
    {
        _title = title;
        _score = "0";

    }

    public void SetScore(string score)
    {
        _score = score;
    }

    public string GetScore()
    {
        return _score;
    }

    public virtual string GetGoal()
    {
        return _title;
    }



    
}