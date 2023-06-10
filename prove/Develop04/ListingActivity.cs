public class ListingActivity : Activity
{
    private string _prompt;

    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void ListStart()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random random = new Random();
        _prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"---  {_prompt}  ---");
        Console.Write("You may begin in:");
        CountDown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string answer = Console.ReadLine();
            i++;
        }

        Console.WriteLine($"You list {i} items.");

    }
}