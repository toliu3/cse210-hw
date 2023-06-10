using System;
namespace Develop04
{
    
class Program
{
    static void Main(string[] args)
    {
            // Loop for choices
        bool repeat = true;
        while (repeat== true)
        {
            Console.WriteLine();    
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity.");
            Console.WriteLine("  2. Start reflecting activity.");
            Console.WriteLine("  3. Start listing activity.");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            //  
            if (choice == "1")
            {
                Console.Clear();
                string name = "Breathing";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                string breatheInActivity = "Breathe in...";
                string breatheOutMessage = "Breathe out...";
                BreathingActivity breathe1 = new BreathingActivity( name, description, breatheInActivity, breatheOutMessage);
                breathe1.DisplayStartMessage();

            }
            else if (choice == "2")
            {

            }

            else if (choice == "3")
            {

            } 

            else
            {
                repeat = false;
            }   

        }
    }    
}
}