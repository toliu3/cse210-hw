class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
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
                BreathingAct breath = new BreathingAct(name, description, "Breathe In...", "Now breathe Out...");
                breath.StartActivity();
                breath.BreatheStart();
                breath.DisplayEndMessage();                

            }
            else if (choice == "2")
            {
                Console.Clear();
                string name = "Reflecting";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflection = new ReflectingActivity(name, description);
                reflection.StartActivity();
                reflection.RefelectStart();
                reflection.DisplayEndMessage();

            }       

            else if (choice == "3")
            {
                string name = "Listing";
                string description =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity list = new ListingActivity(name, description);
                list.StartActivity();
                list.ListStart();
                list.DisplayEndMessage();
            } 

            else
            {
                repeat = false;
            }   

        }
    }    
}
