using System;
using System.Text.RegularExpressions;
public class Word // Replace the letter with "_".
{
    private string _word;

    public Word (string word)
    {
     _word = word;   
    }

    public string HiddenWord()
    {
        string hiddenword = Regex.Replace(_word, "[a-zA-Z]", "_");
        return hiddenword;
    }

}