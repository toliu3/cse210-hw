using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Activity running = new Running(5.0, "03 Nov 2022",30 );
        Activity cycling = new Cycling(25.0, "03 Nov 2022",60);

        Activity swimming = new Swimming(15.0, "03 Nov 2022",30);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }

    }
}