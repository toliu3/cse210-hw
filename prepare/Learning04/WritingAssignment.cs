public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string getWritingInformation = $"The Causes of {_title} by {_studentName}";
        return getWritingInformation;
    }


}