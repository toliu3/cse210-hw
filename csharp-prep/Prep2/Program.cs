using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userinput = Console.ReadLine();
        int score = int.Parse(userinput);
        string grade;
        if (score >= 90)
        {
            grade = "A";                    
        }
        else if (score >=80)
        {
            grade = "B";            
        }
        else if (score >=70)
        {
            grade = "C";
        }
        else if (score >=60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        if (grade =="A" || grade == "B" || grade =="C")
        {
            Console.WriteLine($"Congratualion! YOur grade is {grade}.");            
        }
        else
        {
            Console.WriteLine($"Your grade is {grade}. Please try again.");
        }
    }
}