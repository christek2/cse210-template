using System;
using System.IO;

public class Simple : Goal
{
    public Simple()
    {
        SetType("Simple Goal");
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
            if (line.Substring(4, 1) == "S")
            {
                int index = newLines.IndexOf(line);
                newLines.Remove(line);
                string[] loadedLines = System.IO.File.ReadAllLines(fileName);
                string[] parts = loadedLines[0].Split(" ");
                int loadedPoints = int.Parse(parts[2]);
                SetPointsEarned(loadedPoints + FindPoints(line));
                string newLine = line.Remove(1, 1);
                newLine = newLine.Insert(1, "X");
                newLines.Insert(index, newLine);
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

        Console.WriteLine("Simple goal completed!");
        Thread.Sleep(3000);
    }
}