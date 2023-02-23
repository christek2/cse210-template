using System;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private int _userTime;

    public Activity()
    {}

    public string DisplayStartingMessage()
    {
        return _startingMessage;
    }
    public string DisplayEndingMessage()
    {
        return _endingMessage;
    }
    public void ShowAnimation()
    {}
    public void PauseConsole()
    {}
    public int GetUserTime()
    {
        return _userTime;
    }
    public void SetUserTime(int time)
    {
        _userTime = time;
    }
}