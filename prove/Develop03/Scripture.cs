using System;
using System.Linq;
using System.Collections.Generic;
// This class can split a text with " " and creact a list with words inside.
// Choose the words by radom to be hidden, and the words be replaced by "_".
// Restore the text with the list.
// Determine whether all characters have been hidden.
public class Scripture
{
    private List<string> _words;
    private List<int> _hiddens;


    public Scripture(string text) // Create a list form a text by calling WordList().
    {
        _words = WordList(text);
        _hiddens = new List<int>();
   
    }

    private List<string> WordList(string text) // Split the text with " " and store the words in a list 
    {
        List<string> wordStrings= text.Split(' ').ToList();
        return wordStrings;
    }


    public bool IfAllHidden() //  Check if the all words are hidden.
    {
        if(_hiddens.Count() == _words.Count())
        {
            return true;
        }
        return false;
    }

    public string GetRenderedText() // Restore the text from a list and return.
    {
        Random();
        string str = String.Join(" ", _words);
        return str; 
    }

    private void Random() // Choose 3 non-repeating words to be hidden by random.
    {
      
       Random rnd = new Random();
       for (int i = 0; i<3; i++ ) // 3 wrods everytime.
       {
            if ( _words.Count() == _hiddens.Count()) // Check if the words all are hidden.
                {
                    break;
                }           
            int number = rnd.Next(0, _words.Count());         
            while (_hiddens.Contains(number)) // Check if the word is hidden already. 
            {
               
               number = rnd.Next(0, _words.Count()); // if yes, choose again.        

            }
            _hiddens.Add(number); // Add the hidden word into a list.
            string word = _words[number]; // Find the chosen word.
            string hiddenword =new Word(word).HiddenWord(); // Replace the word with "_".
            _words[number] = hiddenword; // Store back to the list.

        }

    }
}