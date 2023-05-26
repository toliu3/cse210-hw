using System;
using System.Linq;
using System.Collections.Generic;
public class Scripture
{
    private List<string> _words;
    private List<int> _hiddens;


    public Scripture(string text)
    {
        _words = WordList(text);
        _hiddens = new List<int>();
   
    }

    private List<string> WordList(string text)
    {
        List<string> wordStrings= text.Split(' ').ToList();
        return wordStrings;
    }


    public bool IfAllHidden()
    {
        if(_hiddens.Count() == _words.Count())
        {
            return true;
        }
        return false;
    }

    public string GetRenderedText()
    {
        Random();
        string str = String.Join(" ", _words);
        return str; 
    }

    private void Random()
    {
      
       Random rnd = new Random();
       for (int i = 0; i<3; i++ )
       {
            if ( _words.Count() == _hiddens.Count())
                {
                    break;
                }           
            int number = rnd.Next(0, _words.Count());         
            while (_hiddens.Contains(number))
            {
               
               number = rnd.Next(0, _words.Count());         

            }
            _hiddens.Add(number);
            string word = _words[number];
            string hiddenword =new Word(word).HiddenWord();
            _words[number] = hiddenword;

        }
        //foreach (int nu in _hiddens)
        //{
        //    Console.WriteLine(nu); 
            
        //}
        //Console.WriteLine(_hiddens.Count());

    }
}