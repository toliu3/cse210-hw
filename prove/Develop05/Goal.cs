public class Goal
{
    private string _title;

    public Goal(string title)
    {
        _title = title;

    }


    public virtual string GetGoal()
    {
        return _title;
    }



    
}