using System;

public class Checklist : Goal
{
    private int _iterations;
    private int _bonus;

    public Checklist()
    {
        SetType("Checklist Goal");
    }

    public override string Execute()
    {
        return GetInfo();
    }
    public override void RecordEvent(string fileName)
    {
        List<string> newLines = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
  
        foreach (string line in lines)
        {
            newLines.Add(line);
            if (line.Substring(4, 1) == "C")
            {
                string[] loadedLines = System.IO.File.ReadAllLines(fileName);
                string[] parts = loadedLines[0].Split(" ");
                int loadedPoints = int.Parse(parts[2]);
                SetPointsEarned(loadedPoints + FindPoints(line));
                string[] times = line.Split("(");
                int timesComp = int.Parse(times[1].Substring(0, 1));
                SetTimesComplete(timesComp + 1);
                if (GetTimesComplete() == GetTimesToComplete())
                {
                    SetPointsEarned(GetPointsEarned() + _bonus);
                    int index = newLines.IndexOf(line);
                    newLines.Remove(line);
                    string newLine = line.Remove(1, 1);
                    newLine = newLine.Insert(1, "X");
                    newLine = newLine.Remove(21, 1);
                    int proxy = GetTimesComplete();
                    newLine = newLine.Insert(21, $"{proxy}");
                    newLines.Insert(index, newLine);
                }
            }   
        }
        
        newLines.RemoveAt(0);
        Menu menu = new Menu();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    int newPoints = GetPointsEarned();
                    outputFile.WriteLine($"You have {newPoints} points");
                    foreach (string goal in newLines)
                    {
                        outputFile.WriteLine(goal);
                    }
                }

        if (GetTimesComplete() != GetTimesToComplete())
        {
            int completed = GetTimesComplete();
            Console.WriteLine($"Checklist goal completed {completed} time(s)!");
            Thread.Sleep(3000);
        }
        else
        {
            Console.WriteLine("You've completed this Checklist goal!");
            Thread.Sleep(3000);
        }
    }
    public override string GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of this goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with each iteration of this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times would you like this goal to repeat? ");
        _iterations = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for completing all of the iterations? ");
        _bonus = int.Parse(Console.ReadLine());

        return GoToString(GoGetType(), GetName(), GetDescription(), GetPoints(), _iterations, _bonus);
    }
    public override string GoToString(string type, string name, string description, int points, int iterations = 0, int bonus = 0)
    {
        int completed = GetTimesComplete();
        SetTimesToComplete(iterations);
        return $"[ ] {type} ({completed} time(s) complete): {name}; {description}; {points}p; {iterations}x; {bonus} (bonus)";
    }
}