using System;

public class TimeTracker
{
    private int _currentTime;
    private int _totalTime;

    public TimeTracker()
    {}

    public void AddTime(int time)
    {
        _totalTime = _totalTime + time;
    }
    public void DisplayTime()
    {
        Console.WriteLine($"--- You have spent a total of {_totalTime} seconds of activities during this session ---");
    }
    public int GetTime(int time)
    {
        _currentTime = time;
        return _currentTime;
    }
}