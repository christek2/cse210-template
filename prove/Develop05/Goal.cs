using System;

public abstract class Goal
{
    private List<string> _goalTypes = new List<string>();
    private int _userSelection;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _completed;
    private string _fileName;

    public Goal()
    {}

    public void DisplayOptions()
    {}
    public abstract void RecordEvent();
    public abstract void IsComplete(); // type to bool
    public void SaveGoal()
    {}
    public void LoadGoal()
    {}
    public void SetName(string name)
    {}
    public void SetDescription(string description)
    {}
    public void SetPoints(int points)
    {}
    public abstract void Execute();
}