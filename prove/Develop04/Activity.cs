public class Activity
{
    private string _activityName ;
    private string _activityDescription ;
    public int _duration;

    public Activity(string name, string description )
    {
        _activityName = name;
        _activityDescription = description;
    }

    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }

    protected void Spinner(int seconds)
    {
        string [] spinnerFrames = { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i=0;
        while (DateTime.Now < endTime)
        {
            string s = spinnerFrames[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerFrames.Count())
            {
                i = 0;
            }

        }

    }

    public void StartActivity()
    {
    
        DisplayStartMessage();
        Console.Write($"How long, in seconds, would you like in your section? ");
        _duration = int.Parse( Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready....");
        Spinner(5);
        Console.WriteLine();

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Spinner(4);
        Console.Write("\b \b");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        Spinner(6);
        Console.Clear();
                
    }

    protected void CountDown(int n)
    {
        for (int i = n; i >0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}