using System;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private string _goalType;
    private int _goalPoints;
    private List<string> _goalList = new List<string>();
    private bool _isComplete;
    private List<string> _menu1 = new List<string>(){"1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"};
    private List<string> _menu2 = new List<string>(){"1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal"};
    private string _fileName;

    public Goal()
    {}

    public void ShowMenu1()
    {
        Console.Clear();
        foreach (string i in _menu1)
        {
            Console.WriteLine(i);
        }
        Console.Write("Enter the number for the action you would like to complete: ");
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                ShowMenu2();
                break;
            case "2":
                foreach (string goal in _goalList)
                {
                    Console.WriteLine(goal);
                }
                Console.WriteLine();
                Console.Write("Press enter to continue");
                Console.ReadLine();
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
        }
        Console.WriteLine(_goalList[0]);
        // ShowMenu1();
    }
    public void ShowMenu2()
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
        goals[userChoice].Execute();
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
    public string GetType()
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
    public string GetFileName()
    {
        return _fileName;
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public abstract void Execute();
    public abstract void SaveFile();
    public abstract void RecordEvent();
    public void LoadFile(string fileName)
    {
        _fileName = fileName;
    }
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    public virtual string ToString(string type, string name, string description, int points, int iterations = 0, int bonus = 0)
    {
        return $"[] {type}: {name}; {description}; {points}";
    }
    public virtual void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of this goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(Console.Read());

        _goalList.Add("Yo dude");
        // _goalList.Add(ToString(GetType(), GetName(), GetDescription(), GetPoints()));
    }
    public void SetGoal(string goal)
    {
        _goalList.Add(goal);
    }
}