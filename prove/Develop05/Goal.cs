using System;
using System.IO;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private string _goalType;
    private int _goalPoints;
    private bool _isComplete;
    private List<string> _menu1 = new List<string>(){"1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"};
    private List<string> _menu2 = new List<string>(){"1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal"};
    private int _totalPointsEarned;
    private List<string> _goalList = new List<string>();
    private int _timesComplete;
    private int _timesToComplete;

    public Goal()
    {}

    public int GetTimesToComplete()
    {
        return _timesToComplete;
    }
    public void SetTimesToComplete(int times)
    {
        _timesToComplete = times;
    }
    public int GetTimesComplete()
    {
        return _timesComplete;
    }
    public void SetTimesComplete(int times)
    {
        _timesComplete = times;
    }
    public void SetPointsEarned(int points)
    {
        _totalPointsEarned = points;
    }
    public int GetPointsEarned()
    {
        return _totalPointsEarned;
    }
    public void ShowMenu1()
    {
        Console.Clear();
        Console.WriteLine($"You have {_totalPointsEarned} points.");
        Console.WriteLine();
        foreach (string i in _menu1)
        {
            Console.WriteLine(i);
        }
    }
    public string ShowMenu2()
    {
        foreach (string i in _menu2)
        {
            Console.WriteLine(i);
        }
        Dictionary<string, Goal> goals = new Dictionary<string, Goal>();
        goals["1"] = new Simple();
        goals["2"] = new Eternal();
        goals["3"] = new Checklist();

        Console.Write("Which goal would you like to create? ");
        string userChoice = Console.ReadLine();
        return goals[userChoice].Execute();
    }
    public string GetName()
    {
        return _goalName;
    }
    public void SetName(string name)
    {
        _goalName = name;
    }
    public string GetDescription()
    {
        return _goalDescription;
    }
    public void SetDescription(string description)
    {
        _goalDescription = description;
    }
    public string GoGetType()
    {
        return _goalType;
    }
    public void SetType(string type)
    {
        _goalType = type;
    }
    public virtual int GetPoints()
    {
        return _goalPoints;
    }
    public void SetPoints(int points)
    {
        _goalPoints = points;
    }
    public abstract string Execute();
    public abstract void RecordEvent(string fileName);
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    public virtual string GoToString(string type, string name, string description, int points, int iterations = 0, int bonus = 0)
    {
        return $"[ ] {type}: {name}; {description}; {points}p";
    }
    public virtual string GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of this goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));

        return GoToString(GoGetType(), GetName(), GetDescription(), GetPoints());
    }
    public void EnterProgress(string fileName)
    {
        foreach (string i in _menu2)
        {
            Console.WriteLine(i);
        }
        Dictionary<string, Goal> progress = new Dictionary<string, Goal>();
        progress["1"] = new Simple();
        progress["2"] = new Eternal();
        progress["3"] = new Checklist();

        Console.Write("Enter the number for the type of goal you are reporting on: ");
        string userReport = Console.ReadLine();
        progress[userReport].RecordEvent(fileName);
    }
    public int FindPoints(string goal)
    {
        string[] parts = goal.Split(";");
        string pointsFromString = parts[2].Substring(1, parts[2].Count() - 2);
        return int.Parse(pointsFromString);
    }
}