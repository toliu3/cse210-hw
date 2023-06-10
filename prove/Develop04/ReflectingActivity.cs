public class ReflectingActivity : Activity
{
    private string  _prompt;
    private string  _reflectionQuestion;

    private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    private string[] reflectionQuestions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };            

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void RefelectStart()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Random random = new Random();
        _prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"---  {_prompt}  ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        CountDown(5);
        Console.Clear();        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            _reflectionQuestion = reflectionQuestions[random.Next(reflectionQuestions.Length)];
            Console.Write($"> {_reflectionQuestion}");
            Spinner(10);
            Console.WriteLine();

        }

    }

}