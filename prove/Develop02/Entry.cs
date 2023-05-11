using System.IO;
// The responsibility of Entry class is to hold and display an entry information.
public class Entry
{
    //It has 4 member variables in Entry class. _date: string, 
    //_weather: string, _prompt: string, _entry: string.
    
    public string _date;
    public string _weather;
    public string _prompt;
    public string _entry;

    // A method that displays the entry with "date", "weather", "prompt" and the journal  
    // that user writed down.
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}, Weather: {_weather}, Prompt: {_prompt}");
        Console.WriteLine(_entry);
    }

}