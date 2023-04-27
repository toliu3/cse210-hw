using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string impute_magic = Console.ReadLine();
        int magic = int.Parse(impute_magic);
        int guess = 0;
        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            string impute_guess = Console.ReadLine();
            guess = int.Parse(impute_guess);
            if (guess > magic) {
                    Console.WriteLine("Lower");                
                }
            else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
            else 
                {
                    Console.WriteLine("You guess it!");
                }
        }

    }
}