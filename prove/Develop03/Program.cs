using System;

class Program
{
    static void Main(string[] args)
    {
        //Choose a scripture by random.
        ScripturesDic ranscrip = new ScripturesDic();
        //Store a scripture as a dictionary.    
        Dictionary <string, string> randomScripture = ranscrip.GetScrpture();
        string book = randomScripture["Book"];
        string chapter = randomScripture["Chapter"];
        int startVerse = int.Parse(randomScripture["StartVerse"]);
        int endVerse = int.Parse(randomScripture["EndVerse"]);
        string renderedText = randomScripture["Text"];
        string verseRef = "";
        
        if ( endVerse == 0) // Call the constructor for only one verse, and get the reference. 
        {
            Reference reference = new Reference(book, chapter, startVerse);
            verseRef = reference.GetReference();
        }
        else // More than one verse runs the other constructor.
        {
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            verseRef = reference.GetReference();
  
        }
        
        // Call Scripture class
        Scripture scripture = new Scripture(renderedText);
        bool allHidden = false;
          while (allHidden == false) // Create a loop until all words are hidden.
          {
                Console.Clear();
                Console.WriteLine($"{verseRef}  {renderedText}"); // Print the reference and scripture.
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to continue or type 'quit' to finish: ");

                allHidden = scripture.IfAllHidden(); // If all words are hidden, it will get true.
                
                string input = Console.ReadLine();
                if (input=="") // If user press Enter.
                {
                    if (allHidden == true) // If all words are hidden than finishes the program.
                    {
                        break;

                    }
                    // To hide the words and return the rendered text.
                    renderedText = scripture.GetRenderedText();
                }   

                else if (input == "quit") // When the user types "quit" to finish the program.
                {
                    break;
                }
          }
          Console.WriteLine("Program is finished!");
         
    }
}