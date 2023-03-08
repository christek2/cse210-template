using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "GoalTracker.txt";

        Dictionary<string, Goal> goals = new Dictionary<string, Goal>();
        goals["1"] = new Simple();
        goals["2"] = new Eternal();
        goals["3"] = new Checklist();

        Console.WriteLine("Which goal would you like to record? ");
        string choice = Console.ReadLine();

        goals[choice].Execute(fileName);
    }
}