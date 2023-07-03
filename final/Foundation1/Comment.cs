public class Comment
{
    public string _name;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"Commenter: {_name}");
        Console.WriteLine($"Comment: {_comment}");
        
    }

    

}