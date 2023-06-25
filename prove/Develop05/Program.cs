using System;
class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string>();
        goals.Add("0");
        QuestTracker tracker = new QuestTracker(goals);
        string goalName = "gaolName";
        Goal goal = new Goal(goalName);

        bool repeat = true;
        while (repeat== true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {tracker.GetScore()} points");
            Console.WriteLine();    
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
        
            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Enternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string typegoal = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is the name of your gosl? ");
                string title =  Console.ReadLine();
                Console.Write("What is the short description of it? ");
                string description =  Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (typegoal == "1")
                {
                   SimpleGoal simpleGoal = new SimpleGoal("SimpleGoal", title, description, points);
                   string goalRecord = simpleGoal.GetGoal();
                   goals = tracker.UpdateGoal(goalRecord);
                }
                else if (typegoal == "2")
                {
                   EternalGoal eternalGoal = new EternalGoal("EternalGoal", title, description, points);
                   string goalRecord = eternalGoal.GetGoal();
                   goals = tracker.UpdateGoal(goalRecord);
                }
                else if (typegoal == "3")
                {
                   Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                   string times =  Console.ReadLine();
                   Console.Write("What is the bonus for accomplishing it that many times? ");
                   string bonus = Console.ReadLine();
                   ChecklistGoal checklistGoal = new ChecklistGoal("ChecklistGoal", title, description, points, times, bonus);
                   string goalRecord = checklistGoal.GetGoal();
                   goals = tracker.UpdateGoal(goalRecord);
                }


            }
            else if (choice == "2") 
            {

                tracker.DisplayGoals();                
            }       

            else if (choice == "3")
            {
                string score = tracker.GetScore().ToString();
                goals[0] = score;
                tracker.SaveGoals(goals);
            } 

            else if (choice == "4")
            {
                goals = tracker.LoadGoals();
            } 
            else if (choice == "5")
            {
                tracker.RecordEvent();
            } 


            else
            {

                repeat = false;
            }   
        }
                

    }

}
