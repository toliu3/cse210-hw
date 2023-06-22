using System;
using System.Collections.Generic;
using System.IO;


public class QuestTracker
{
    private string _fileName;
    private int _score;

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
                    if (bool.Parse(parts[4]) == false)
                        Console.WriteLine($"{n}. [ ] {parts[1]} ({parts[2]}) ");
                    else if (bool.Parse(parts[4]) == true)
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

    public void SaveGoals(List<string> goals)
    {
        Console.Write("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (string item in goals)
            {
                writer.WriteLine(item);
            }
        }
    }

    public List<string> LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            int item = parts.Count();
            if (item == 1)
            {
                _score = int.Parse(parts[0]);
            }
            _goals.Add(line);
        }
        return _goals;
    }

    public int GetScore()
    {
        return _score;
    }

}