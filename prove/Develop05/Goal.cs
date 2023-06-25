using System.Collections.Generic;

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

    public virtual string RecordEvent(List<string> lines)
    {
        return _gaolName;
    }





    
}