using System.Collections.Generic;
public class Reference // Generate the reference.
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _reference;


    public Reference(string book, string chapter, int startVerse ) // With one verse
    {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _reference =$"{_book} {_chapter}:{_startVerse}";
            
    }

    public Reference(string book, string chapter, int startVerse, int endVerse )
       // With more than one verse. 
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;       
        _reference =$"{_book} {_chapter}:{_startVerse}-{_endVerse}"; 
    }

    public string GetReference() // Return the reference.
    {
        
        return _reference;
    }

}