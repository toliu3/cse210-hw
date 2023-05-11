using System;
using System.IO; 

public class Program
{
    static void Main(string[] args)
    {
        // Greeting
        Console.WriteLine("Weclcome to the Journal Program!");
        Journal journalBook = new Journal();
        Journal journalLoad = new Journal();
        
        // Add the prompts to list _prompts
        PromtGenerator prompts = new PromtGenerator();    
            prompts._Prompts.Add("Who was the most interesting person I interacted with today? ");
            prompts._Prompts.Add("What was the best part of my day? ");
            prompts._Prompts.Add("How did I see the hand of the Lord in my life today? ");
            prompts._Prompts.Add("What was the strongest emotion I felt today? ");
            prompts._Prompts.Add("If I had one thing I could do over today, what would it be? ");
            prompts._Prompts.Add("What was the person or thing I should thank for today? ");
            prompts._Prompts.Add("What was the good thing I did today? ");
            prompts._Prompts.Add("What did I pray for today?");

        // Loop for choices
        bool repeat = true;
        while (repeat== true)
        {
        Console.WriteLine();    
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What do you want to do? ");
        string choice = Console.ReadLine();

        //  To write a entry
        if (choice == "1")
        {
            // Call calss Entry 
            Entry journal = new Entry();
            Console.Write("How is the weather today? ");
            //Set _weather
            journal._weather = Console.ReadLine();
            // Get a prompt by call method random().
            string prompt = prompts.random();
            Console.WriteLine($"prmpt: {prompt}");
            // Set _prompt
            journal._prompt = prompt;
            // Set the _entry
            journal._entry = Console.ReadLine();
            // Set the current date
            DateTime theCurrentTime = DateTime.Now;
            journal._date = theCurrentTime.ToShortDateString();
            //Add to a list 
            journalBook._journals.Add(journal);

        }
        // Display the journals both load and current writting 
        // by calling Displayj() method.
        else if (choice == "2")
        {
            journalLoad.Displayj();
            journalBook.Displayj();
        }
        // Ask user the filename that he wants to load
        // by calling LoadFile() method and restoring to a list
        else if (choice == "3")
        {
            Console.WriteLine("What is the filename you want ot load?");
            journalLoad._filename = Console.ReadLine();
            journalLoad._journals = journalLoad.LoadFile();

        }
        // Ask the user filename that he wants to save
        // by calling SaveFilej() method  
        else if (choice == "4")
        {
            Console.WriteLine($"What is the filename? ");
            journalBook._filename = Console.ReadLine();
            journalBook.SaveFilej();
            
        }
        // Quit the loop
        else
        {
            repeat = false;
        }
        }
    }
}