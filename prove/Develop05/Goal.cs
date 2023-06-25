public class Goal
{
    private string _gaolName;


    public Goal(string goalName)
    {
        _gaolName = goalName;

    }


    public virtual string GetGoal()
    {
        return _gaolName;
    }






    
}