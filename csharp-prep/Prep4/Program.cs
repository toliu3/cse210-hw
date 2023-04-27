using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finsished. ");
        int number = 1;
        float sum = 0;
        do
        { 
            Console.Write("Enter number: ");
            string imput = Console.ReadLine();
            number = int.Parse(imput);
            numbers.Add(number);
            sum += number;
        }while (number != 0);

        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int maxnumber = numbers[0];
        foreach (int num in numbers)
            {
                if (num > maxnumber)
                    {
                        maxnumber = num;
                    }
            }
        Console.WriteLine($"The largest number is: {maxnumber}");



    }
}