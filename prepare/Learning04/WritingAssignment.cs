public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        string getWritingInformation = $"The Causes of {_title} by {studentName}";
        return getWritingInformation;
    }


}