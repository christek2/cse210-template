using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string value = Console.ReadLine();

        float grade = float.Parse(value);

        string letter = "n/a";

        Console.WriteLine(grade);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Error");
        }
        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Good luck next time!");
        }
    }
}