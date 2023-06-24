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
        SimpleGoal simplegoal = new SimpleGoal("SimpleGoal");
        EternalGoal eternalgoal = new EternalGoal("EternalGoal");
        ChecklistGoal checklistgoal = new ChecklistGoal("ChecklistGoal");

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
                if (typegoal == "1")
                {
                   string goalRecord = simplegoal.GetGoal();
                   goals = tracker.UpdateGoal(goalRecord);
                }
                else if (typegoal == "2")
                {
                   string goalRecord = eternalgoal.GetGoal();
                   goals = tracker.UpdateGoal(goalRecord);
                }
                else if (typegoal == "3")
                {
                   string goalRecord = checklistgoal.GetGoal();
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
