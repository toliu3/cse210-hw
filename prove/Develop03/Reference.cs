using System.Collections.Generic;
public class Reference
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _reference;
    private string _text;




    public Reference(string book, string chapter, int startVerse )
    {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _reference =$"{_book} {_chapter}:{_startVerse}";
            
    }

    public Reference(string book, string chapter, int startVerse, int endVerse )

    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;       
        _reference =$"{_book} {_chapter}:{_startVerse}-{_endVerse}"; 
    }

    public string GetReference()
    {
        
        return _reference;
    }

}