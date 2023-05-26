using System;

class Program
{
    static void Main(string[] args)
    {
        ScripturesDic ranscrip = new ScripturesDic();
        Dictionary <string, string> randomScripture = ranscrip.GetScrpture();
        string book = randomScripture["Book"];
        string chapter = randomScripture["Chapter"];
        int startVerse = int.Parse(randomScripture["StartVerse"]);
        int endVerse = int.Parse(randomScripture["EndVerse"]);
        string renderedText = randomScripture["Text"];
        string verseRef = "";

        if ( endVerse == 0)
        {
            Reference reference = new Reference(book, chapter, startVerse);
            verseRef = reference.GetReference();
        }
        else 
        {
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            verseRef = reference.GetReference();
  
        }
        
        Scripture scripture = new Scripture(renderedText);
        bool allHidden = false;
          while (allHidden == false)
          {
                Console.Clear();
                Console.WriteLine($"{verseRef}  {renderedText}");
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to continue or type 'quit' to finish: ");

                allHidden = scripture.IfAllHidden();

                
                string input = Console.ReadLine();
                if (input=="")
                {
                    if (allHidden == true)
                    {
                        break;

                    }

                    renderedText = scripture.GetRenderedText();
                }   

                else if (input == "quit")
                {
                    break;
                }
          }
          Console.WriteLine("Program is finished!");
         
    }
}