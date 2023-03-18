using System;
using System.IO;

public class Menu : Goal
{
    private string _fileName;
    private List<string> _goalList = new List<string>();

    public Menu()
    {
        _fileName = "";
    }

    public List<string> GetList()
    {
    return _goalList;
    }
    public void AddToList(string item)
    {
    _goalList.Add(item);
    }
    public override string Execute()
    {
        return "something";
    }
    public void SaveFile(List<string> goalList)
    {
        if (_fileName == "")
        {
            Console.WriteLine("No file loaded. First load a file and then save your goals");
            Thread.Sleep(3000);
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                outputFile.WriteLine($"You have {GetPointsEarned} points");
                foreach (string goal in goalList)
                {
                    outputFile.WriteLine(goal);
                }
                Console.WriteLine($"Goals saved to {_fileName}.");
                Thread.Sleep(3000);
            }
        }
    }
    public override void RecordEvent(string fileName)
    {}
    public string GetFileName()
    {
        return _fileName;
    }
    public void LoadFile()
    {
        Console.Write("Enter your file name here: ");
        _fileName = Console.ReadLine();
        Console.WriteLine($"{_fileName} loaded.");
        Thread.Sleep(3000);
    }
    public void DisplayGoals()
    {
        if (_fileName == "" && _goalList.Count() == 0)
        {
            Console.WriteLine("No file loaded and no goals entered. Load a file or enter goals.");
            Thread.Sleep(3000);
        }
        else
        {
            if (_goalList.Count() == 0)
            {
                string[] lines = System.IO.File.ReadAllLines(_fileName);
                Console.WriteLine($"From {_fileName}:");

                foreach (string line in lines)
                {
                    if (line.Substring(0, 1) != "Y")
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.WriteLine();
                Console.Write("--Press enter to continue--");
                Console.ReadLine();
            }
            else 
            {
                foreach (string goal in _goalList)
                        {
                            Console.WriteLine(goal);
                        }
                        Console.WriteLine();
                        Console.Write("--Press enter to continue--");
                        Console.ReadLine();
            }
        }
    }
}