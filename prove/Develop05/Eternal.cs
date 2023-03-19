using System;
using System.IO;

public class Eternal : Goal
{
    public Eternal()
    {
        SetType("Eternal Goal");
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
            if (line.Substring(4, 1) == "E")
            {
                string[] loadedLines = System.IO.File.ReadAllLines(fileName);
                string[] parts = loadedLines[0].Split(" ");
                int loadedPoints = int.Parse(parts[2]);
                SetPointsEarned(loadedPoints + FindPoints(line));
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

        Console.WriteLine("You have accomplished the Eternal goal! Keep it up!");
        Thread.Sleep(3000);
    }
}