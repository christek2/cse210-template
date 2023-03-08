using System;

public class Menu
{
    private List<string> _options = new List<string>();
    private List<string> _goalTypes = new List<string>();
    private string _fileName;
    private string _goal;
    private List<string> _goalList = new List<string>();
    private int _goalPoints;
    private bool _repeat;

    public Menu()
    {
        _options.Add("1. Create New Goal");
        _options.Add("2. List Goals");
        _options.Add("3. Save Goals");
        _options.Add("4. Load Goals");
        _options.Add("5. Record Event");
        _options.Add("6. Quit");
        
        _goalTypes.Add("1. Simple Goal");
        _goalTypes.Add("2. Eternal Goal");
        _goalTypes.Add("3. Checklist Goal");

        _repeat = true;
    }

    public string DisplayOptions()
    {
        foreach (string opt in _options)
        {
            Console.WriteLine(opt);
        }
        Console.Write("Enter the number for the action you would like to select: ");
        string userInput = Console.ReadLine();

        return userInput;
    }
    public string DisplayGoalTypes()
    {
        foreach (string type in _goalTypes)
        {
            Console.WriteLine(type);
        }
        Console.Write("\nEnter the number for the type of goal you would like to record: ");
        string userType = Console.ReadLine();

        return userType;
    }
    public string GetFileName()
    {
        return _fileName;
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public bool AskForOption()
    {
        Console.WriteLine($"You have {GetPoints()} points.\n");

        string choice = DisplayOptions();
        switch (choice)
        {
            case "1":
                AskForGoal();
                break;
            case "2":
                ListGoals();
                break;
            case "3":
                SaveFile(_fileName);
                break;
            case "4":
                LoadFile();
                break;
            case "5":
                RecordProgress();
                break;
            case "6":
                _repeat = false;
                break;
        }
        return _repeat;
    }
    public void AskForGoal()
    {
        string choice = DisplayGoalTypes();
        string fileName = "GoalTracker.txt";

        Dictionary<string, Goal> goals = new Dictionary<string, Goal>();
        goals["1"] = new Simple();
        goals["2"] = new Eternal();
        goals["3"] = new Checklist();

        goals[choice].Execute(fileName);
    }
    public void RecordProgress()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        string userGoal = Console.ReadLine();

        Dictionary<string, Goal> goals = new Dictionary<string, Goal>();
        goals["1"] = new Simple();
        goals["2"] = new Eternal();
        goals["3"] = new Checklist();

        goals[userGoal].RecordEvent();
    }
    public string GetGoal()
    {
        return _goal;
    }
    public void SetGoal(string goal)
    {
        _goal = goal;
    }
    public List<string> GetGoalList()
    {
        return _goalList;
    }
    public void AddGoal(string goal)
    {
        _goalList.Add(goal);
    }
    public void SetPoints(int points)
    {
        _goalPoints = points;
    }
    public int GetPoints()
    {
        return _goalPoints;
    }
    public void ListGoals()
    {
        foreach (string goal in _goalList)
        {
            Console.WriteLine(goal);
        }
        Console.WriteLine();
    }
    public void SaveFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetPoints());
            foreach (string goal in _goalList)
            {
                outputFile.WriteLine(goal);
            }
        }
    }
    public void LoadFile()
    {
        Console.WriteLine("Enter the name of the text file you would like to load ");
        string fileName = Console.ReadLine();
        _fileName = fileName;
    }
}