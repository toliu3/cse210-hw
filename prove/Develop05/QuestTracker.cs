using System;
using System.Collections.Generic;
using System.IO;


public class QuestTracker
{
    private string _fileName;
    private int _score;
    private int _points;

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
                    if (parts[4] != parts[5])
                    {
                        Console.WriteLine($"{n}. [ ] {parts[1]} ({parts[2]}) -- Currently completed: {parts[4]}/{parts[5]}");
                        n += 1;

                    }
                    else
                    {
                        Console.WriteLine($"{n}. [X] {parts[1]} ({parts[2]}) -- Currently completed: {parts[4]}/{parts[5]}");
                        n += 1;
                    }
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
        _goals.Clear();        
        string[] lines = File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            _goals.Add(line);
        }
        _score = int.Parse(_goals[0]);
        return _goals;
    }

    public int GetScore()
    {
        return _score;
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int n = 1; 

        foreach (string value in _goals)
        {
           
            string[] parts = value.Split(',');
            int item = parts.Count();
            if (item != 1)
            {
                Console.WriteLine($"{n}. {parts[1]} ");   
                n += 1;

            }
        }
       Console.Write("Which goal did you accomplish? ");
       int ans = int.Parse (Console.ReadLine());
       string[] lines = _goals[ans].Split(',');
       if (lines[0] == "SimpleGoal" )
       {
            _points = int.Parse (lines[3]);
            _score += _points;
            Congratulate(_points, _score);
            lines[4] = "True";
            string line = string.Join(",", lines);
            _goals[ans] = line;

       }
       else if (lines[0] == "EternalGoal" )
       {
            _points = int.Parse (lines[3]);
            _score += _points;
             Congratulate(_points,_score);
            string line = string.Join(",", lines);
            _goals[ans] = line;
               
       }
       else if (lines[0] == "ChecklistGoal")
       {
            int no = int.Parse(lines[4]);
            no += 1;
            if (no.ToString() != lines[5])
            {
                _points = int.Parse (lines[3]);
                _score += _points;
                Congratulate(_points, _score);
                lines[4] = no.ToString();
                string line = string.Join(",", lines);
                _goals[ans] = line;
            }
            else 
            {
                _points = int.Parse (lines[6]);
                _score += _points;
                Congratulate(_points, _score);
                lines[4] = no.ToString();
                string line = string.Join(",", lines);
                _goals[ans] = line;

            }

       }


    }

    private void Congratulate(int points, int score)
    {
        Console.WriteLine($"Congrutulations! you have earned {points} points!");
        Console.WriteLine($"YOu now have {score} points"); 
    }


}