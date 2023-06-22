using System;
using System.Collections.Generic;
private string _filename;

public class QuestTracker
{
    public List<string> _goals;
    public QuestTracker( List<string> goals)
    {
        _goals = goals;
    }
    
    public List<string> UpdateGoal(string goal)
    {
        _goals.Add(goal);
        return _goals;

    }
    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        int n = 1;
        foreach (string value in _goals)
        {
            string[] parts = value.Split(',');
                if (parts[0] == "SimpleGoal")
                {
                    Console.WriteLine($"{n}. [ ] {parts[1]} ({parts[2]}) ");
                    if (parts[4] == "true")
                    {
                      Console.WriteLine($"{n}. [X] {parts[1]} ({parts[2]}) ");   
                    }
                   
                    n += 1;
                }
                else if (parts[0] == "EternalGoal")
                {
                    Console.WriteLine($"{n}. [ ] {parts[1]} ({parts[2]}) ");
                    n += 1;
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    Console.WriteLine($"{n}. [ ] {parts[1]} ({parts[2]}) -- Currently completed: {parts[4]}/{parts[5]}");
                    n += 1;
                }
            

        }

    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        _filename = Console.ReadLine();

    }
}