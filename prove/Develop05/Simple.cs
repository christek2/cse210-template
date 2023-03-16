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
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            if (line.Substring(4, 1) == "S")
            {
                Console.WriteLine(line);
            }
        }
        Thread.Sleep(3000);
    }
}