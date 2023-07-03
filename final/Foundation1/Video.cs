public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public int _no;
    public List<Comment> _comments;


    public void Display()
    {
        int no = _comments.Count();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video length: {_videoLength} seconds.");
        Console.WriteLine($"The nummber of comments: {no}");
        foreach ( Comment comment in _comments )
        {
            comment.Display();
        }
        Console.WriteLine();    
        
    }


}