using System;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _isComplete;
    private List<string> _menu1 = new List<string>();
    private List<string> _menu2 = new List<string>();
    private string _fileName;

    public Goal()
    {}

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
    public virtual int GetPoints()
    {
        return _goalPoints;
    }
    public void SetPoints(int points)
    {
        _goalPoints = points;
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
    public override string ToString()
    {
        return "Some string indicating completion";
    }
}